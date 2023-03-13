using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public class River
    {
        public string Name { get; set; }
        public double Square { get; set; }
        public double Length { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько рек нужно: ");
            int count = int.Parse(Console.ReadLine());

            var rivers = new List<River>();

            for (int i = count; i > 0; i++)
            {
                var river = new River();

                Console.Write("Введите название: ");
                river.Name = Console.ReadLine();

                Console.Write("Введите площадь: ");
                river.Square = Double.Parse(Console.ReadLine());

                Console.Write("Введите протяженность: ");
                river.Length = Double.Parse(Console.ReadLine());

                rivers.Add(river);
                Console.WriteLine("Река добавлена!");
            }
        }
    }
}