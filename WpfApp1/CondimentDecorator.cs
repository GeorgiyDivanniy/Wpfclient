using System;

namespace ConsoleApp1
{
    public abstract class CondimetDecorator : Beverage
    {
        public abstract override string getDescription();
    }

    class Sugar : CondimetDecorator
    {
        Beverage beverage;
        
        public Sugar(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Sugar";
        }
        public override double cost()
        {
            return 0.20 + beverage.cost();
        }
    }

    class Soy : CondimetDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
        public override double cost()
        {
            return 0.50 + beverage.cost();
        }
    }

    class Whip : CondimetDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
        public override double cost()
        {
            return 0.75 + beverage.cost();
        }
    }

    class Milk : CondimetDecorator
    {
        Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", Milk";
        }
        public override double cost()
        {
            return 0.15 + beverage.cost();
        }
    }

}

