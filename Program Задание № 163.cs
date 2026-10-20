using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program163
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Код единицы (1 — дм, 2 — км, 3 — м, 4 — мм, 5 — см): ");
            if (!int.TryParse(Console.ReadLine(), out int unit)) { Console.WriteLine("Ошибка."); return; }

            Console.Write("Значение длины: ");
            if (!double.TryParse(Console.ReadLine(), out double value) || value < 0) { Console.WriteLine("Ошибка значения."); return; }

            double meters;

            switch (unit)
            {
                case 1: meters = value / 10.0; break;      // дм → м
                case 2: meters = value * 1000.0; break;   // км → м
                case 3: meters = value; break;             // м → м
                case 4: meters = value / 1000.0; break;   // мм → м
                case 5: meters = value / 100.0; break;    // см → м
                default:
                    Console.WriteLine("Неверная единица.");
                    return;
            }

            Console.WriteLine($"{value} в метрах: {meters:F3}");
        }
    }
}
