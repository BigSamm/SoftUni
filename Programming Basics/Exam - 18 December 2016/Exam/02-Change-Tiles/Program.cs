using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 60 min
namespace _02_Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var subr_pari = double.Parse(Console.ReadLine());
            var pod_shir = double.Parse(Console.ReadLine());
            var pod_dulj = double.Parse(Console.ReadLine());
            var plochka_str = double.Parse(Console.ReadLine());
            var plochka_vis = double.Parse(Console.ReadLine());
            var plochka_cena = double.Parse(Console.ReadLine());
            var maistor = double.Parse(Console.ReadLine());

            var pod_plosht = pod_shir * pod_dulj;
            var plochka_plosht = plochka_str * plochka_vis / 2.0;
            var neobh_plochki = Math.Ceiling(pod_plosht / plochka_plosht) + 5.0;
            var obshta_suma = (neobh_plochki * plochka_cena) + maistor;
            var result = Math.Round(subr_pari - obshta_suma, 2);

            if(
                (subr_pari >= 0.0 && subr_pari <= 5000.0) &&
               (pod_shir >= 0.0 && pod_shir <= 5000.0) &&
               (pod_dulj >= 0.0 && pod_dulj <= 5000.0) &&
               (plochka_str >= 0.0 && plochka_str <= 5000.0) &&
               (plochka_vis >= 0.0 && plochka_vis <= 5000.0) &&
               (plochka_cena >= 0.0 && plochka_cena <= 5000.0) &&
               (maistor >= 0.0 && maistor <= 5000.0))
            {            
            if (result >= 0) Console.WriteLine("{0:f2} lv left." , result);
            else if (result < 0) Console.WriteLine("You'll need {0:f2} lv more.", Math.Abs(result));
            }
            
            

            
        }
    }
}
