

namespace Homework2_Builder.Factory
{
    abstract class CarFactoryBase
    {
        protected readonly CarBuilderBase CarBuilder;

        protected CarFactoryBase(CarBuilderBase builder)
        {
            CarBuilder = builder;
        }

        public abstract Car Construct();
    }
}
