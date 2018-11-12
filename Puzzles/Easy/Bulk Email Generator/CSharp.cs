/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Bulk Email Generator         */
/* Difficulty: Easy                     */
/* Date solved: 12.11.2018              */
/*                                      */
/****************************************/

using System;
using System.Text.RegularExpressions;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int N = int.Parse(Console.ReadLine());

        string[] emailTemplateLines = new string[N];

        for (int i = 0; i < N; i++)
        {
            emailTemplateLines[i] = Console.ReadLine();
        }

        string emailTemplate = string.Join("\n", emailTemplateLines);
        int choicesCounter = -1;

        //Find all choices.
        string email = new Regex(@"\([^)]*\)").Replace(emailTemplate, (match) => 
        {
            choicesCounter++;

            //Replace the choices using "random".
            string[] choices = match.Value.Substring(1, match.Value.Length - 2).Split('|');
            return choices[choicesCounter % choices.Length];
        });

        //Output email.
        Console.WriteLine(email);
    }
}