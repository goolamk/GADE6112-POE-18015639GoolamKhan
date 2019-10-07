using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_18015639GoolamKhan
{
    public abstract class Buildings
    {
        protected int XPos;
        protected int YPos;
        protected int Health;
        protected int MaxHealth;
        protected int Faction;
        protected string Symbol;

        public abstract void Death();
        public abstract override string ToString();
    }
}
