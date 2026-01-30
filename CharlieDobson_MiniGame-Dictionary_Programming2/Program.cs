using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_MiniGame_Dictionary_Programming2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Initialize a dictionary called monsterHealths.
            This is a dictionary which holds monster names (strings) as the keys and health amounts (int) as values. 
            Initialize it with 5 different monster health pairs, NOT using .Add()

            Adding a new Monster
            You need to add a new monster. 
            Be sure to check if the monster exists in the dictionary already! You cannot add monsters that already exist. 
            If it already exists, write to the console: "Tried to add a monster that already exists!" 

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



        }
    }
}
