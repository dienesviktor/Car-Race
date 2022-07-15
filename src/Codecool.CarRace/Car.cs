using System;

namespace Codecool.CarRace
{
    public class Car : Vehicles
    {

        public Car()
            : base(CalculateNormalSpeed())
        { }

        protected const int YELLOW_FLAG_SPEED = 75;

        public override void PrepareForLap(Race race)
        {
            if (race.IsThereABrokenTruck)
            {
                ActualSpeed = YELLOW_FLAG_SPEED;
            }
            else
            {
                ActualSpeed = NormalSpeed;
            }
        }

        private static int CalculateNormalSpeed()
        {
            return RandomHelper.NextInt(80, 110 + 1);
        }

        private static readonly string[] POSSIBLE_NAMES =
        {
            "Legacy",
            "Enigma",
            "Temperament",
            "Might",
            "Whirlpool",
            "Quicksilver",
            "Cobra",
            "Nimbus",
            "Prodigy",
            "Supremacy"
        };

        private string GetName() => RandomHelper.ChooseOne(POSSIBLE_NAMES);

        protected override string GenerateName()
        {
            return $"{GetName()} {GetName()}";
        }
    }
}
