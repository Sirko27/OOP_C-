using Task3_Hunter;

Random rand = new Random();
Hunter Hunter = new Hunter();
Hunter Hunter1 = new Hunter("Толік", 85, 12, 3, 2);
Сompetition сompetition;

bool _play = true;
int _number_option;
int _health_hunter1 = Hunter1.Health;

Hunter.GetInfoHunter(Hunter1);

//Реалізація меню
do
{
    //Назви пунктів меню
    Console.WriteLine("\nДії з мисливцем:");
    Console.WriteLine("1 Полювати при умові якщо (Здоровя як мінімум 5, та мисливець має хочаб одну стрілу)");
    Console.WriteLine("2 Продати здобич (Одна здобич коштує 3 золота)");
    Console.WriteLine("3 Відновити здоровя до " + _health_hunter1 + "xp (Одне здоровя коштує 2 золота)");
    Console.WriteLine("4 Придбати стрілу (Стрівла коштує 1 золото)");
    Console.WriteLine("5 Розпочати змагання з іншим мисливцем (5 спроб хто вполює більше здобичі)");
    Console.WriteLine("6 Інформація про мисливця");
    Console.WriteLine("0 Закінчити сеанс");


    try
    {
        Console.Write("Оберіть пункт меню: ");
        int.TryParse(Console.ReadLine(), out _number_option);

        switch (_number_option)
        {
            case 1:
                Hunter1.Hunt();
                break;

            case 2:
                Hunter1.Sell_prey();
                break;

            case 3:
                Hunter1.Regain_health();
                break;

            case 4:
                Hunter1.Buy_arrow();
                break;

            case 5:
                Hunter Hunter2 = new Hunter("Дмитро", 100, 8, 5, 0);
                Hunter Hunter3 = new Hunter("Іван", 100, 8, 5, 0);
                if ((Hunter2.Arrows >= 5 && Hunter2.Health >= 25) && (Hunter3.Arrows >= 5 && Hunter3.Health >= 25))
                    сompetition = new Сompetition(Hunter2, Hunter3);
                break;

            case 6:
                Hunter.GetInfoHunter(Hunter1);
                break;

            case 0:
                _play = false;
                break;

            default:
                Console.WriteLine("Обрано неіснуючу функцію");
                break;
        }
    }
    catch { Console.WriteLine("Некоректно введені дані"); }
}
while (_play == true);