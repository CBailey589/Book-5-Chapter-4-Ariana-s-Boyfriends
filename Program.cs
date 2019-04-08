using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ariana's boyfriends
            // Pete Davidson
            // Ricky Alvarez
            // Big Sean
            // Jai Brooks
            // Nathan Sykes
            // Graham Phillips

            Dictionary<string, string> boyfriends = new Dictionary<string, string>();
            boyfriends.Add("Pete Davidson", "boyfriend");
            boyfriends.Add("Ricky Alvarez", "boyfriend");
            boyfriends.Add("Big Sean", "boyfriend");
            boyfriends.Add("Jai Brooks", "boyfriend");
            boyfriends.Add("Nathan Sykes", "boyfriend");
            boyfriends.Add("Graham Phillips", "boyfriend");

            // Add Ariana's boyfriends to the boyfriends dictionary with the {key name, value boyfriend} ex. {Big Sean, boyfriend}


            // I want you to change the value boyfriend to ex-boyfriend ex {Big Sean, ex-boyfriend}, if Pete Davidson change the value to ex-fiance ex {Pete Davidson, ex-fiance}

            // display the results "Ariana's {value} is {key}"

            Dictionary<string, string> exBoyfriends = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> BF in boyfriends)
            {
                exBoyfriends[BF.Key] = "ex-boyfriend";
                if (BF.Key == "Pete Davidson")
                {
                    exBoyfriends["Pete Davidson"] = "ex-fiance";
                }
            }

            foreach (KeyValuePair<string, string> dude in exBoyfriends)
            {

                Console.WriteLine($"Ariana's {dude.Value} is {dude.Key}");
            }
        }
    }
}
