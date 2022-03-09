using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetRpgDIO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType): base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}