using FeatureManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class UserTarget : IUserTarget
    {
        public Func<User, bool> Func { get; } = (user) => true;

        public UserTarget() { }

        public UserTarget(Expression<Func<User, bool>> expression)
        {
            Func = expression.Compile();
        }

        public bool IsMatch(User user)
        {
            return Func(user);
        }
    }
}
