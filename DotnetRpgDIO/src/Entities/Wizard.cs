using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetRpgDIO.src.Entities
{
    public class Wizard: Hero 
    {
    
        public String TypeMagic { get; set; } = "White";
        public Wizard(string Name, int Level, string HeroType): base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack() { 
            if (this.TypeMagic == "Black") {
             return this.Name + "Lançou magia negra.";   
            }
            else if (TypeMagic == "White") {
                return this.Name + "Lançou magia branca.";
            }
            else {
                return this.Name + "Lançou magia.";
            }
        }

        
    }
}