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

        public override string ToString()
        {
            string str = "Пол: " + sex + "\nРост: " + height + "\nВес: " + weight + "\nЧерты характера: " + traits +
                "\nСемейное положение: " + marital_status + "\nНаличие детей: " + children;
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var arraySex = new string[] {"женщина", "мужчина"};
            var arrayHeight = new int[] { 162, 156, 160, 170, 163, 167, 172, 182, 185, 186, 190, 164 };
            var arrayWeigth = new int[] { 45, 46, 47, 58, 49, 50, 51, 52, 53, 54, 55, 56, 60, 62, 65, 67 };
            var arrayTraits = new string[] { "добрый", "раздражительный", "молчаливый", "общительный", "дружелюбный", "пессимист", "оптимист", "агрессивный", "замкнутый", "странный" };
            var arrayMarital = new string[] { "в браке", "в активном поиске", "разведен/на", "помолвлен/на"};
            var arrayChildren = new string[] { "имеются", "не имеются" };
            int number;

            Random rand = new Random();
            
            Human[] humans = new Human[500];

            for (int i = 0; i < 500; i++)
            {
                humans[i] = new Human();
                humans[i].Sex = arraySex[rand.Next(maxValue: arraySex.Length)];
                humans[i].Height = arrayHeight[rand.Next(maxValue: arrayHeight.Length)];
                humans[i].Weight = arrayWeigth[rand.Next(maxValue: arrayWeigth.Length)];
                humans[i].Traits = arrayTraits[rand.Next(maxValue: arrayTraits.Length)];
                humans[i].Marital_status = arrayMarital[rand.Next(maxValue: arrayMarital.Length)];
                humans[i].Children = arrayChildren[rand.Next(maxValue: arrayChildren.Length)];                             
            }
            do
            {
                Console.WriteLine("Введите номер человека");
                number = int.Parse(Console.ReadLine());
                if ((number >= 0) && (number < 500))
                {
                    Console.WriteLine(humans[number].ToString());
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
