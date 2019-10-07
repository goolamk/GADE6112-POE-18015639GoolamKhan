using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_18015639GoolamKhan
{
    public class ResourceBuilding : Buildings
    {
        //isDead field used for Death method
        public bool IsDead { get; set; }
        public int xPos
        {
            get { return base.XPos; }
        }
        public int yPos
        {
            get { return base.YPos; }
        }
        public int health
        {
            get { return base.Health; }
            set { base.Health = value; }
        }

        public int maxHealth
        {
            get { return base.MaxHealth; }
        }
        public int faction
        {
            get { return base.Faction; }
        }

        public string symbol
        {
            get { return base.Symbol; }
            set { base.Symbol = value; }
        }

        string ResTyp = "More Armor";
        int ResGen = 0;
        int ResGenPerR = 5;
        int ResRem = 50000;

        public ResourceBuilding(int x, int y, int h, int f, string sy, string rt, int rg, int rgpr, int rr)
        {
            base.XPos = x;
            base.YPos = y;
            Health = h;
            base.MaxHealth = h;
            base.Faction = f;
            symbol = sy;
            IsDead = false;
            ResTyp = rt;
            ResGen = rg;
            ResGenPerR = rgpr;
            ResRem = rr;

        }
        public override void Death()
        {
            symbol = "/";
            IsDead = true;
        }

        public override string ToString()
        {
            string temp = "";
            temp += "Resouce building: ";
            temp += "{" + Symbol + "}";
            temp += "(" + xPos + "," + yPos + ")";
            temp += Health + ", " + ResGenPerR + ", " + ResRem;
            temp += "[" + ResTyp + "]";
            temp += (IsDead ? " DEAD!" : " ALIVE!");
            return temp;
        }

        public int resGen()
        {
            return ResGen;
        }
    }
}
