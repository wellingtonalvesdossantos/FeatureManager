using FeatureManager.Core.Interfaces;
using System.Linq.Expressions;

namespace FeatureManager.Core
{
    public class DistanceTarget : IDistanceTarget
    {
        public Func<double, bool> Func { get; } = (distance) => true;

        public DistanceTarget() { }

        public DistanceTarget(Expression<Func<double, bool>> expression)
        {
            Func = expression.Compile();
        }

        public bool IsMatch(double distance)
        {
            return Func(distance);
        }
    }
}
