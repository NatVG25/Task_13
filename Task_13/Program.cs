using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул.8 марта, 12", 74, 21, 52); //создаем экземпляр класса Building
            building.Print(); //выводим на консоль информацию о здании методом Print
           
            MultiBuilding multiBuilding = new MultiBuilding("ул. 8 марта, 18", 56, 23, 87, 15); //создаем экземпляр класса MultiBuilding
            multiBuilding.Print(); //выводим на консоль информацию о здании методом Print
            Console.ReadKey();
        }
    }
    class Building
    {
        public string address { get; set; } //автосвойство
        int length; //поле
        int width; //поле
        int height; //поле
                  
        public int Lenght //свойство
        {
               set
               {
                   if (value > 0)
                   {
                      length = value;
                   }
                   else
                   {
                      Console.WriteLine("Длина здания не может быть отрицательной!");
                   }
               }
               get
               {
                   return length;
               }
        }

        public int Width //свойство
        {
               set
               {
                   if (value > 0)
                   {
                       width = value;
                   }
                   else
                   {
                       Console.WriteLine("Ширина здания не может быть отрицательной!");
                   }
               }
               get
               {
                    return width;
               }
        }
        public int Height //свойство
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Высота здания не может быть отрицательной!");
                }
            }
            get
            {
                return height;
            }
        }
        
        public Building(string address, int lenght, int width, int height) //конструктор родительского класса
        {
            this.address = address;
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public void Print() //метод вывода информации о здании
        {
            Console.WriteLine("Здание по адресу:{0} имеет длину {1} м, ширину {2} м, высоту {3} м", address, length, width, height);
        }

    }
   sealed class MultiBuilding : Building //класс- наследник
   {
        int floor;
        public int Floor //свойство
        {
            set
            {
                if (value > 0)
                {
                    floor = value;
                }
                else
                {
                    Console.WriteLine("Количество этажей не может быть отрицательным!");
                }
            }
            get
            {
                return floor;
            }
        }
        public MultiBuilding (string address, int lenght, int width, int height, int floor)
            :base(address, lenght, width, height) //вызываем родительский конструктор
        {
            this.Floor = floor;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей: {0}", floor);
        }
   }

}   
