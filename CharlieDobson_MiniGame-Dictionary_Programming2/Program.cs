using System;
using System.Collections.Generic;
using System.Linq;

namespace CharlieDobson_MiniGame_Dictionary_Programming2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<string, int> monsterHealth = new Dictionary<string, int>
            {
                {"Goblin", 10},
                {"Light Monster", 50 },
                {"Troll", 50 },
                {"Sneeker", 15 },
                {"Barbarian", 150 }
            };

            while (true)
            {
                Console.WriteLine("Insert a new monster name: ");
                string newMonsterName = Console.ReadLine();

                if (monsterHealth.ContainsKey(newMonsterName))
                {
                    Console.WriteLine("CANNOT ADD NEW MONSTER! MONSTER EXISTS!");
                }
                else
                {
                    Console.WriteLine("Add Monster Health");
                    string newMonsterHealth = Console.ReadLine();

                    if (int.TryParse(newMonsterHealth, out int result))
                    {
                        Console.WriteLine($"New monster added! {newMonsterName} with {result} health");
                        monsterHealth.Add(newMonsterName, result);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("NOT A NUMBER!");
                    }
                }
            }
            Console.ReadKey(true);
            Console.Clear();

            foreach (var kvp in monsterHealth)
            {
                Console.WriteLine($"Monster name: {kvp.Key} with {kvp.Value} health.");
            }



            while (true)
            {
                Console.WriteLine("What Monster's health do you want to see?");
                string thisMonsterName = Console.ReadLine();
                int thisMonstersHealth;

                if(monsterHealth.ContainsKey(thisMonsterName))
                {
                    if(monsterHealth.TryGetValue(thisMonsterName, out var result))
                    {
                        thisMonstersHealth = result;
                        Console.WriteLine($"Your monster has {thisMonstersHealth} health.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This shouldn't happen. They should have a health. How tf did you end up there.");
                    }
                }
                else
                {
                    Console.WriteLine("This monster doesn't exist.");
                }
            }

            foreach(var kvp in monsterHealth.Keys.ToList())
            {
                monsterHealth[kvp] += 10;
            }
            foreach (var kvp in monsterHealth)
            {
                Console.WriteLine($"Monster name: {kvp.Key} with {kvp.Value} health.");
            }





        }
    }
}
