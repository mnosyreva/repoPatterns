
namespace Homework2_Builder
{
    abstract class CarBuilderBase
    { 
        protected Car Car;

        protected CarBuilderBase()
        {
            Car = new Car();
        }

        public Car GetCar()
        {
            return Car;
        }

        public abstract void BuildMultimedia();
        public abstract void BuildWheels();
        public abstract void BuildEngine();
        public abstract void BuildFrames();
        public abstract void BuildLuxury();
        public abstract void BuildSafety();
    }
}