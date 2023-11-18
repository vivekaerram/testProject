using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType)
        {
            return swallowType switch
            {
                SwallowType.African => new AfricanSwallow(),
                SwallowType.European => new EuropeanSwallow(),
                _ => throw new ArgumentException("Invalid swallow type")
            };
        }
    }

    public abstract class Swallow
    {
        public SwallowLoad Load { get; private set; }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public abstract double GetAirspeedVelocity();
    }

    public class AfricanSwallow : Swallow
    {
        public override double GetAirspeedVelocity()
        {
            return Load == SwallowLoad.None ? 22 : 18;
        }
    }

    public class EuropeanSwallow : Swallow
    {
        public override double GetAirspeedVelocity()
        {
            return Load == SwallowLoad.None ? 20 : 16;
        }
    }
}
