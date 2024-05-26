// See https://aka.ms/new-console-template for more information

using FeatureManager.Core;
using FeatureManager.Core.Appliers;
using FeatureManager.Core.Contexts;
using FeatureManager.Core.Enums;
using FeatureManager.Core.Extensions;
using FeatureManager.Core.Interfaces;
using FeatureManager.Core.Protections;
using FeatureManager.Core.Providers;
using FeatureManager.Core.Translations;
using FeatureManager.Core.ViewModels;
using Microsoft.Extensions.DependencyInjection;

var personViewModel = new PersonViewModel() 
{ 
    CPF = "999.999.999-99", BirthDate = new(1992, 3, 6), Name = "Fulano",
    Profession = new("Developer", EProfessionLevel.SR)
};

var serviceProvider = BuildServiceProvider();

var translator = serviceProvider.GetRequiredService<IApplicationTranslator>();
var applicationDateTime = serviceProvider.GetRequiredService<IApplicationDateTime>();
var loggedUserContext = serviceProvider.GetRequiredService<IGlobalContext<User>>();
var geolocationProvider = serviceProvider.GetRequiredService<IProvider<GeoLocation>>();
var person = translator.Translate<Person>(personViewModel);
var age = person.BirthDate!.Value.GetAge(applicationDateTime.TodayDate);
var user = new User(person, new("fulano.santos"), new("12345678"));
loggedUserContext.SetValue(user);

Console.WriteLine("Geolocalização atual: "+ geolocationProvider.Provide());
var regularTargetWho = new UserTarget((user)
    => user != null &&
       user!.Person != null &&
       user!.Person!.Profession != null && 
       user!.Person!.Profession!.Name!.Equals("developer", StringComparison.CurrentCultureIgnoreCase) &&
       user!.Person!.Profession!.Level == EProfessionLevel.SR);
var regularTargetWhenDayOfWeek = new DayOfWeekTarget(DayOfWeek.Monday, DayOfWeek.Thursday);
var regularTargetWhenTime = new TimeTarget(new(8,0), new(17,0));
var regularWho = new RestrictionWho(regularTargetWho);
var regularWhenDayOfWeek = new RestrictionWhen(regularTargetWhenDayOfWeek);
var regularWhenTime = new RestrictionWhen(regularTargetWhenTime);
var regularBlock = new RestrictionBlock("Regime padrão")
{
    Who = [regularWho],
    When = [regularWhenDayOfWeek, regularWhenTime]
};

var exceptionTargetWho = new UserTarget((user)
    => user != null &&
       user!.Person != null &&
       user!.Person!.Profession != null &&
       user!.Person!.Profession!.Name!.Equals("tech lead", StringComparison.CurrentCultureIgnoreCase));
var exceptionWho = new RestrictionWho(exceptionTargetWho);
var exceptionBlock = new RestrictionBlock("Regime de exceção")
{
    Who = [exceptionWho]
};

var deployPrdAction = new FeatureAction("Publicar em PRD")
{
    RestrictionBlocks = [regularBlock, exceptionBlock]
};

//simulando evento de 2hrs
var checkinTargetWhen = new DateTimeTarget(DateTime.Now.AddHours(-1), DateTime.Now.AddHours(2));
var checkinWhen = new RestrictionWhen(checkinTargetWhen, "A partir de 1hr antes do evento");
var checkinTargetWhere = new DistanceTarget((distance) => distance <= 5000);
var checkinWhere = new RestrictionWhere(checkinTargetWhere, "Num raio de 5km");
var checkinBlock = new RestrictionBlock("Permite fazer check-in a partir de 1hr antes do evento num raio de 5km")
{
    When = [checkinWhen],
    Where = [checkinWhere]
};
var checkInAction = new FeatureAction("Check-in")
{
    RestrictionBlocks = [checkinBlock],
    Geolocation = new(-23.1924662, -46.8811222)
};

var validator = serviceProvider.GetRequiredService<FeatureActionValidator>();
var deployPrdValidationResult = validator.Validate(deployPrdAction);
var checkinValidationResult = validator.Validate(checkInAction);

Console.ReadKey();

static ServiceProvider BuildServiceProvider()
{
    var services = new ServiceCollection();
    services.AddAutoMapper((mapper) =>
    {
        mapper.AddProfile(new TypeProfile());
        mapper.AddProfile(new ViewModelProfile());
    });
    services.AddSingleton<IApplicationDateTime, ApplicationDateTime>();
    services.AddSingleton<IApplicationDirectory, ApplicationDirectory>();
    services.AddSingleton<IApplicationTranslator, ApplicationTranslator>();
    services.AddSingleton<IGlobalContext<User>, LoggedUserContext>();
    services.AddSingleton<IProvider<GeoLocation>, GeoLocationProvider>();
    services.AddTransient<WhenApplier>();
    services.AddTransient<WhereApplier>();
    services.AddTransient<WhoApplier>();
    services.AddTransient<FeatureActionValidator>();
    return services.BuildServiceProvider();
}