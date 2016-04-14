using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_CRYSTaLLL_bub
{
    class Program
    {
        static void Main(string[] args)
        {
            FortuneTeller fortuneTeller = new FortuneTeller();
            Crystal crystalBall = new Crystal();
            fortuneTeller.Greet();
            fortuneTeller.StartService((Service)crystalBall);
            crystalBall.Work();
            crystalBall.Show();
            crystalBall.StateEffectiveness();
            fortuneTeller.Farewell();



        }

       

        
    }
}
