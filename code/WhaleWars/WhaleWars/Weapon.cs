using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    public class Weapon
    {
        protected int range;
        protected int upperDamage;
        protected int lowerDamage;
        protected string name;
        protected WeaponType type;

        public Weapon(string nm, int rg, int ud, int ld, WeaponType ty)
        {
            name = nm;
            range = rg;
            upperDamage = ud;
            lowerDamage = ld;
            type = ty;
        }
    }
}
