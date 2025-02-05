using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_karamov
{
    public class RobotClass
    {
        public int life;
        public int GetLife()
        {
            return life;
        }
        public void Min(int a)
        {
            Random rng = new Random();
            life = a;
            life = rng.Next(0, (a*70/100));
        }
        public void Kol(int a, int k)
        {
            if (k == a / 2)
            {
                life = life + 30;
            }
            else if (k == a * 0.7)
            {
                life += 20;
            }
        }
    }
}
