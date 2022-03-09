using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetRpgDIO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " atacou com a sua espada";
        }

        public string Attack(int Bonus) { 
            if (Bonus > 6) {
                return this.Name + "Lançou magia super efetiva com bonus de " + Bonus;
            } 
            else {
                return this.Name + "Lançou magia com força fraca com bonus de " + Bonus;

            }
        }

    }
}