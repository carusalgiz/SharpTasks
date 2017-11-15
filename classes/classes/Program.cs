using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Human
    {
        private string sex;
        private int height;
        private int weight;
        private string traits;
        private string marital_status;
        private string children;

        public string Sex { get => sex; set => sex = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Traits { get => traits; set => traits = value; }
        public string Marital_status { get => marital_status; set => marital_status = value; }
        public string Children { get => children; set => children = value; }

        public void show()
        {
            Console.WriteLine("Пол: " + sex);
            Console.WriteLine("Рост: " + height);
            Console.WriteLine("Вес: " + weight);
            Console.WriteLine("Черты характера: " + traits);
            Console.WriteLine("Семейное положение: " + marital_status);
            Console.WriteLine("Наличие детей: " + children);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] arraySex = new string[] {"женщина", "мужчина"};
            int[] arrayHeight = new int[] { 162, 156, 160, 170, 163, 167, 172, 182, 185, 186, 190, 164 };
            int[] arrayWeigth = new int[] { 45, 46, 47, 58, 49, 50, 51, 52, 53, 54, 55, 56, 60, 62, 65, 67 };
            string[] arrayTraits = new string[] { "добрый", "раздражительный", "молчаливый", "общительный", "дружелюбный", "пессимист", "оптимист", "агрессивный", "замкнутый", "странный" };
            string[] arrayMarital = new string[] { "в браке", "в активном поиске", "разведен/на", "помолвлен/на"};
            string[] arrayChildren = new string[] { "имеются", "не имеются" };
            int number;

            Random rand = new Random();
            
            Human[] humans = new Human[500];

            for (int i = 0; i < 500; i++)
            {
                humans[i] = new Human();
                humans[i].Sex = arraySex[rand.Next(2)];
                humans[i].Height = arrayHeight[rand.Next(maxValue: arrayHeight.Length)];
                humans[i].Weight = arrayWeigth[rand.Next(maxValue: arrayWeigth.Length)];
                humans[i].Traits = arrayTraits[rand.Next(maxValue: arrayTraits.Length)];
                humans[i].Marital_status = arrayMarital[rand.Next(4)];
                humans[i].Children = arrayChildren[rand.Next(2)];                             
            }
            do
            {
                Console.WriteLine("Введите номер человека");
                number = int.Parse(Console.ReadLine());
                if ((number >= 0) && (number < 500))
                {
                     humans[number].show();
                    Console.WriteLine("-----------------------");
                }
                else
                {
                    Console.WriteLine("Человека с таким номером не существует.");
                }                
            } while (number != -1);
        }
    }
}
