using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HW220323
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём экземпляр класса Car с помощью паттерна Builder
            Car car = new CarBuilder()
                .WithName("My Car") // Устанавливаем название машины
                .WithBody("Sedan") // Устанавливаем тип кузова
                .WithEngine(200) // Устанавливаем мощность двигателя
                .WithWheels(4) // Устанавливаем количество колёс
                .WithKpp("Automatic") // Устанавливаем тип КПП
                .Build(); // Создаём экземпляр класса Car на основе установленных свойств

            // Выводим информацию об объекте на консоль
            Console.WriteLine(car);

            // Радуемся :)
            Console.ReadKey();
        }
    }
}
