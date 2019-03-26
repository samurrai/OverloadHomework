using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tank> friends = new List<Tank>();
            for (int i = 0; i < 5; i++)
            {
                friends.Add(new Tank("T-34"));
            }

            List<Tank> enemies = new List<Tank>();
            for (int i = 0; i < 5; i++)
            {
                enemies.Add(new Tank("Pantera"));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(friends[i].GetCharacteristic());
                Console.WriteLine(enemies[i].GetCharacteristic());
                Console.WriteLine("Бой! --------------");
                try {
                    if (friends[i] * enemies[i] == 1)
                    {
                        Console.WriteLine("Победил союзный танк!");
                    }
                    else
                    {
                        Console.WriteLine("Победил вражеский танк!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ничья!");
                }
            }
        }
    }
}
