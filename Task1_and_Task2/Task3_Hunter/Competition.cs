using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace Task3_Hunter
{
    public class Сompetition
    {
        Random rand = new Random();
        Hunter Hunter1;
        Hunter Hunter2;
        int _start_Prey_Hunter1;
        int _start_Prey_Hunter2;

        public Сompetition(Hunter hunter1, Hunter hunter2)
        {
            Hunter1 = hunter1;
            Hunter2 = hunter2;
            _start_Prey_Hunter1 = hunter1.Prey;
            _start_Prey_Hunter2 = hunter2.Prey;
            Hunt();
        }

        private void Hunt()
        {
            Hunter1.GetInfoHunter(Hunter1);
            Hunter2.GetInfoHunter(Hunter2);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Раунд " + (i + 1) + "/" + "5");
                Hunter1.Arrows--;
                Hunter2.Arrows--;

                int temp = rand.Next(0, 6);
                Hunter1.Health -= temp;
                Console.WriteLine($"Полювальник {Hunter1.Name} отримав {temp} шкоди");

                temp = rand.Next(0, 6);
                Hunter2.Health -= temp;
                Console.WriteLine($"Полювальник {Hunter2.Name} отримав {temp} шкоди");

                temp = rand.Next(0, 2);
                if (temp == 1)
                {
                    Console.WriteLine(Hunter1.Name + " вполював здобич");
                    Hunter1.Prey++;
                }

                temp = rand.Next(0, 2);
                if (temp == 1)
                {
                    Console.WriteLine(Hunter2.Name + " вполював здобич");
                    Hunter2.Prey++;
                }
            }

            Hunter1.GetInfoHunter(Hunter1);
            Hunter2.GetInfoHunter(Hunter2);

            if ((Hunter1.Prey - _start_Prey_Hunter1) > (Hunter2.Prey - _start_Prey_Hunter2))
                Console.WriteLine(Hunter1.Name + " Переміг");
            else if ((Hunter1.Prey - _start_Prey_Hunter1) < (Hunter2.Prey - _start_Prey_Hunter2))
                Console.WriteLine(Hunter2.Name + " Переміг");
            else
                Console.Write("Нічия");
        }
    }
}
