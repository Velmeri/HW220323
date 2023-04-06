using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW220323
{
    public class Car
    {
        public string Name { get; set; } // Название машины
        public string Body { get; set; } // Тип кузова
        public int Engine { get; set; } // Мощность двигателя
        public int Wheels { get; set; } // Количество колёс
        public string Kpp { get; set; } // Тип КПП

        public override string ToString()
        {
            return
                $"Name: {Name}\n" +
                $"Body: {Body}\n" +
                $"Engine: {Engine}\n" +
                $"Wheels: {Wheels}\n" +
                $"KPP: {Kpp}";
        }
    }

    public class CarBuilder
    {
        private readonly Car _car = new Car(); // Создаём экземпляр класса Car

        public CarBuilder WithName(string name) // Метод для установки названия машины
        {
            _car.Name = name;
            return this;
        }

        public CarBuilder WithBody(string body) // Метод для установки типа кузова
        {
            _car.Body = body;
            return this;
        }

        public CarBuilder WithEngine(int hp) // Метод для установки мощности двигателя
        {
            _car.Engine = hp;
            return this;
        }

        public CarBuilder WithWheels(int r) // Метод для установки количества колёс
        {
            _car.Wheels = r;
            return this;
        }

        public CarBuilder WithKpp(string kpp) // Метод для установки типа КПП
        {
            _car.Kpp = kpp;
            return this;
        }

        public Car Build() // Метод для создания экземпляра класса Car на основе установленных свойств
        {
            return _car;
        }
    }
}