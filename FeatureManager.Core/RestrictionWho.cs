using FeatureManager.Core.Interfaces;

namespace FeatureManager.Core
{
    public class RestrictionWho : BaseRestriction
    {
        public IUserTarget UserTarget { get; }

        public RestrictionWho(IUserTarget userTarget)
        {
            UserTarget = userTarget;
        }

        public RestrictionWho(IUserTarget userTarget, string name) : base(name)
        {
            UserTarget = userTarget;
        }

        public RestrictionWho(IUserTarget userTarget, string name, string description) : base(name, description)
        {
            UserTarget = userTarget;
        }

        public bool IsMatch(User user)
        {
            return UserTarget.IsMatch(user);
        }
    }
}
