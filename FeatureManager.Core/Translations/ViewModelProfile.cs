using AutoMapper;
using FeatureManager.Core.Types;
using FeatureManager.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Translations
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile() 
        {
            CreateMap<Person, PersonViewModel>().ReverseMap();
            CreateMap<LegalPerson, LegalPersonViewModel>().ReverseMap();
        }
    }
}
