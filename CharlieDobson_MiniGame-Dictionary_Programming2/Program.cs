using System;
using System.Collections.Generic;

namespace CharlieDobson_MiniGame_Dictionary_Programming2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             

            

            Get the HP of a monster and display it
            Declare an integer variable and store the HP of any monster in the dictionary in it. 
            You should first check to make sure the key for that monster exists in the dictionary! 
            Write it to the console. 

            Increase every monster's hp by 10.
            You will have to loop through the dictionary to do this! 

            Finally, display all the monsters HP's
            You will either need to do another loop, or add a line of code to the previous step. 
             */

            Dictionary<string, int> monsterHealth = new Dictionary<string, int>
            {
                {"Goblin", 10},
                {"Light Monster", 50 },
                {"Troll", 50 },
                {"Sneeker", 15 },
                {"Barbarian", 150 }
            };

          while(true)
            {
                Console.WriteLine("Insert a new monster name: ");
                string newMonsterName = Console.ReadLine();

                if(monsterHealth.ContainsKey(newMonsterName))
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


        }
    }
}
