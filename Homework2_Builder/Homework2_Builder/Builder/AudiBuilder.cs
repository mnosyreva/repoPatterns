

namespace Homework2_Builder
{
    class AudiBuilder : CarBuilderBase
    {
        public AudiBuilder() : base()
        {
        }

        public override void BuildMultimedia()
        {
            Car.Multimedia = "Audi MMI Multimedia";
        }

        public override void BuildWheels()
        {
            Car.Wheels += " 18\" Audi Wheel";
        }

        public override void BuildEngine()
        {
            Car.Engine = "2.0 TFSI";
        }

        public override void BuildFrames()
        {
            Car.Frame = "Audi frame";
        }

        public override void BuildLuxury()
        {
            Car.Luxury = "Audi Exclusive Interior";
        }

        public override void BuildSafety()
        {
            Car.Safety = "Side Assist";
        }
    }
}
