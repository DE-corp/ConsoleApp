using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Animal
    {
        private string name;
        private float speed;
        private int age;
        private string color;

        public Animal(string name, float speed, int age, string color)
        {
            this.name = name;
            this.speed = speed;
            this.age = age;
            this.color = color;

            show();
        }

        private void show()
        {
            int days_age = this.age * 365;
            Console.WriteLine($"{this.name} двигается со скоростью {this.speed} километров в час. Имеет {this.color} цвет и ему {days_age} дней.\n");
        }
    }
}