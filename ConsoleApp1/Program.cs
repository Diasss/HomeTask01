using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            string str0 = new string('*', 20);
            string str1 = "г Алматы";
            string str2 = "г Алматы";

            if (str1 == str2)
            { }
            if (str1.Equals(str2))
            { }

            if (string.Compare(str1, str2, true)==0) //capsock
            { }

            Console.WriteLine(str1.CompareTo(str2));
            //1

            //2 concat
            string result = "Адрес:";
            result = result + str1;

            string.Concat(result, str1, " - " , str2);

            //contains проверка есть ли определенный знак или строка в строке

            Console.WriteLine(result.Contains("2"));

            //StartWith EndWith

            string card = "4002**0327**7395**5051";
            //6695
            //123
            if (card.StartsWith("4003"))
            {
                Console.WriteLine("Visa");
            }
            // IndexOf LastIndexOf
            string url = "https://e.mail.ru/messages/inbox/?back=1";
            int findPlace2 = url.LastIndexOf("&", 0);//с конца
            int findPlace1 = url.IndexOf("&", 0); //первый параметр то, что мы ищем, второй - то, с какой позиции будем искать
            Console.WriteLine(findPlace1);

            //split join

            string[] cardArr = card.Split(' ');
            string[] cardArr2 =
                card.Split(new String[] { "**" },
                StringSplitOptions.None
                );
            string cardJoin = string.Join("-", cardArr2);

            //trim Удаление начала и конца
            string address = " city Almaty}";
            string trimAddress = address.TrimEnd('}'); //в конце

            //insert remove-удаление replace- замена

            address = address.Insert(1, "Адресс"); //1 параметр с какой позиции, второй параметр - то, что хотим вставить
            address = address.Remove(0, 1); //первый параметр - позиция, второй параметр сколько символов
            address = address.Replace("city", " город "); //находит city ВО ВСЕЙ строке и заменяет на город
            //substring
            var test = address.Substring(0, 5); //1 параметр - позиция, второй то, сколько символов

            DateTime currentDate = DateTime.Now;
            string format = string.Format("{0:hh:mm}", currentDate);

            Console.WriteLine("{0:00.00}", 125.23124);

            //StringBuilder
            StringBuilder sb = new StringBuilder("Привет Мир");
            sb.Append(" - 6126123125");
        }
        static void 
    }
}
