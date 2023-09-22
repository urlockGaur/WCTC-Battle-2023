using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class BattleAxe : IWeapon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public BattleAxe(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}