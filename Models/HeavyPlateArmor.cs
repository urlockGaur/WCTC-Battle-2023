﻿using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class HeavyPlateArmor : IArmor
    {
        public string Name { get; set; }
        public int Defense { get; set; }

        // constructor
        public HeavyPlateArmor(string name, int defense)
        {
            Name = name;
            Defense = defense;
        }
    }
}
