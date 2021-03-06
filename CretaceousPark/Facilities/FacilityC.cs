﻿using CretaceousPark.Dinosaurs;
using CretaceousPark.Generators;
using System;
using System.Collections.Generic;

namespace CretaceousPark.Facilities
{
    public class FacilityC: Facility
    {
        public FacilityC(Dinosaur dino) : base(dino)
        {
            perimeter = Constants.FacilityCPerimeter;

            InstantiateGenerators();
            PowerUp();
            PopulateFacility(Constants.FacilityCEmployeeCount, Constants.FacilityCSecurity);
            PrintStatus();
        }

        public void InstantiateGenerators()
        {
            Generator generator1 = new CircleGenerator();
            generator1.SetPowerLevel(1);

            Generator generator2 = new TriangleGenerator();
            generator2.SetPowerLevel(5);

            Generator generator3 = new TriangleGenerator();
            generator3.SetPowerLevel(2);

            Generator generator4 = new OctagonGenerator();
            generator4.SetPowerLevel(4);

            Generator generator5 = new RectangleGenerator();
            generator5.SetPowerLevel(5);

            Generator generator6 = new OctagonGenerator();
            generator6.SetPowerLevel(2);
            generators = new List<Generator>()
            {
                generator1,
                generator2,
                generator3,
                generator4,
                generator5,
                generator6,
            };
        }
    }
}
