using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Klass
{
    internal class Bank
    {
        public static string ReadFromConsoleName()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            return name;
        }
        public static int ReadFromConsoleAge()
        {
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;


        }
        public static int ReadFromConsoleProductCount()
        {
            Console.WriteLine("Введите количество продуктов");
            int productCount = Convert.ToInt32(Console.ReadLine());
            return productCount;
        }
        public static int ReadFromConsoleSumMoney()
        {
            Console.WriteLine("Введите сумму средств");
            int sumMoney = Convert.ToInt32(Console.ReadLine());
            return sumMoney;

        }
        public static void AnswerPromotion(int age, int productCount, int sumMoney) 
        {
        if (age>60||sumMoney>1000000)
            {
                Console.WriteLine($"{"Поздравляем!"} {"Вы учавствуете в акции"}");
            }
        else if(productCount>=3&&sumMoney>400000)
            {
                Console.WriteLine($"{"Поздравляем!"} {"Вы учавствуете в акции"}");

            }
        else
            {
                Console.WriteLine($" {"Для вас нет никаких акций"}");
            }
        }
    }
}
