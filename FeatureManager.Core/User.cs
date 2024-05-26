using FeatureManager.Core.Types;

namespace FeatureManager.Core
{
    public class User
    {
        public Person Person { get; set; } = new();
        public Username Username { get; set; } = new();
        public Password Password { get; set; } = new();

        public User() { }

        public User(Person person, Username username, Password password)
        {
            Person = person;
            Username = username;
            Password = password;
        }

        public override string? ToString() => Username.Value;
    }
}
