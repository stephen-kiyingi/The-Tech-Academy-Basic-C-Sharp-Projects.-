using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

internal class Program
    {
    static void Main(string[] args)
    {
        //Part 1
        //Creating one dimesnional array of strings.
        string[] wordstart = {
                "im coming ",
                "where love "
          };
        string[] wordend = {
                "home.",
                "love is always enough for me."
          };
        List<string> responses = new List<string>();
        //ask the user to input some text.
        Console.WriteLine("insert any noun:");
        responses.Add(Console.ReadLine());
        Console.WriteLine("please enter the any car model made in canada:");
        responses.Add(Console.ReadLine());
        Console.WriteLine("please enter an adjective");
        responses.Add(Console.ReadLine());
        //create a loop that goes through each string in the array , adding the user"s text to the string.
        for (int i = 0; i < wordstart.Length; i++)
        {
            wordstart[i] += responses[i];
            Console.WriteLine(wordstart[i] + wordend[i]);
        }
        Console.ReadLine();
        Console.WriteLine("Strings were used:");
        //create a loop that prints off each string in the array on a separate line.
        for (int i = 0; i < wordstart.Length; i++)
        {
            Console.WriteLine(wordstart[i] + wordend[i]);
            //part2
            //create an infinite loop
            //fix the infinite loop
        }
        Console.ReadLine();

        //part 3 of the code
        Console.WriteLine("is that a ghost?!");
        StringBuilder boo = new StringBuilder();
        boo.Append("B");
        //create a loop where the comparison that is used to determine whether to continue iterating the loop is a "<" opearator.
        while (boo.Length > 10)
        {
            boo.Append(" o ");
        }
        boo.Append("!");
        Console.ReadLine();
        Console.WriteLine(boo);
        Console.ReadLine();
        StringBuilder ahh = new StringBuilder();
        ahh.Append("A");
        //Add a loop where the comparison that used to determine whether to continue iterating  the loop is a "<=" opeartor.
        while (ahh.Length <= 10)
        {
            ahh.Append('h');
        }
        ahh.Append("!");
        Console.WriteLine(ahh);
        Console.ReadLine();

        //part4
        //create a list of strings where each item in the list is unique.
        List<string> names = new List<string>() { "James", "Tom", "Jane", "Mike" };
        Console.WriteLine(names);
        //ask the user to input text to search for in the list.
        Console.WriteLine("Enter the name");
        int standing = 0;
        bool isValid = false;
        int index = 0;
        //create a loop that iterates through the list and then display the index of the array that contains matching text on the screen.
        while (!isValid)
        {
            int i2 = 0;
            string namerequest = Console.ReadLine();
            foreach (string name in names)
            {
                if (name == namerequest)
                {
                    standing = i2 + 1;
                    index = i2;
                }
            }
            //add code to the above loop that tells a user if they put in text that isnt in the list.
            if (standing == 0)
            {
                Console.WriteLine("invalid name. Enter again");
            }
            // add code to that above loop that stops it from executing once a match has been found.
            else
            {
                isValid = true;
            }
        }
        Console.WriteLine("Processing.... Index is : " + index + ". so...");
        Console.WriteLine("standing is: " + standing);
        Console.ReadLine();

        //part5
        //create a list of striongs that has at least two identical strings in the list.
        List<string> Games = new List<string>() { "Win", "Lose", "draw" };
        Console.WriteLine("Grand draw results \n if you have a paper with a win type" + "\"Win\".\n if you have a paper with draw type\"draw\".\nOtherwise type \"Lose\".");
        //ask the user to select text to search for in the list.
        Console.WriteLine("enter selection:");
        string selection = Console.ReadLine();
        while (!(selection == "Win" || selection == "Lose" || selection == "draw"))
        {
            //add code that tells a user if they put in text that isnt in the list.
            Console.WriteLine("please enter one of the 3 choices");
            selection = Console.ReadLine();
        }
        Console.WriteLine("The games that match your selection are numbered:");
        //create a loop that iterates through the loop and then display the indices of the array that contain matching text on the screen.
        for (int s = 0; s < Games.Count; s++)
        {
            if (selection == Games[s])
            {
                Console.WriteLine(s);
            }

        }
        Console.ReadLine();
        //part 6
        //create a list of strings that has at least two identical strings in the list.
        List<string> teams = new List<string>() { "miami", "Golden", "Magic", "miami", "bulls", "Heats", "Heats" };
        List<string> repeatCheck = new List<string>();
        Console.WriteLine("Basketball Teams:");
        //create a foreach loop that evaluates each item in the list ,and display a meassage showing the string and whether or not it has already appeared in the list.
        foreach (string team in teams)
        {
            Console.WriteLine(team);
            if (repeatCheck.Contains(team))
            {
                Console.WriteLine("This team has been repeated.\nUse last team initial when referring to the basketball team.");

            }
            else
            {
                Console.WriteLine("This team has not been repeated.");
            }
            repeatCheck.Add(team);
        }
        Console.ReadLine();
    }

       

}
