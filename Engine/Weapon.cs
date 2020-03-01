using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public Weapon(int iD, string name, string namePlural, int minimunDamage, int maximumDamage) : base(iD, name, namePlural)
        {
            MinimumDamage = minimunDamage;
            MaximumDamage = maximumDamage;
        }

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

    }
}