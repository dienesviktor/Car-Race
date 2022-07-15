﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Codecool.CarRace
{
    public class Race
    {

        private readonly List<Vehicles> _vehicles = new();

        private Weather _weather = new Weather();

        public bool IsThereABrokenTruck { get; private set; }

        public bool IsRaining => _weather.IsRaining;

        private static readonly int NUM_OF_LAPS = 50;

        public void SimulateRace()
        {
            for (int i = 0; i < NUM_OF_LAPS; i++)
            {
                foreach (Vehicles vehicle in _vehicles)
                {
                    vehicle.PrepareForLap(this);
                    vehicle.MoveForAnHour();
                }

                // change weather and update broken truck status after the movement done
                _weather.Randomize();
                IsThereABrokenTruck = GetBrokenTruckStatus();
            }
        }

        private bool GetBrokenTruckStatus()
        {
            foreach (Vehicles vehicle in _vehicles)
            {
                if (vehicle is Truck)
                {
                    Truck truck = (Truck)vehicle;
                    if (truck.IsBrokenDown)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void PrintRaceResults()
        {
            foreach (var vehicle in _vehicles.OrderByDescending(x => x.DistanceTravelled))
                Console.WriteLine(vehicle);
        }

        public void RegisterRacer(Vehicles racer)
        {
            _vehicles.Add(racer);
        }
    }
}
