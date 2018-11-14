/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Text formatting              */
/* Difficulty: Easy                     */
/* Date solved: 13.11.2018              */
/*                                      */
/****************************************/

using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution
{
    public static void Main()
    {
        //Read input.
        string text = Console.ReadLine().ToLower().Trim();

        //Remove excessive spaces.
        text = Regex.Replace(text, @"\s{2,}", " ");
        
        //Remove spaces before and after punctuations.
        text = Regex.Replace(text, @"\s?\p{P}\s?", (match) => 
        {
            return match.Value.Trim();
        });
        
        //Remove repeated punctuations.
        text = Regex.Replace(text, @"\p{P}+", (match) => 
        {
            return match.Value.Trim()[0].ToString();
        });
        
        //First letter uppercase.
        text = string.Join(".", text.Split('.').Select(s => StringToPascalCase(s)));
        
        //Add spaces after punctuations.
        text = Regex.Replace(text, @"\p{P}", (match) => 
        {
            return match.Value + " ";
        });

        //Output formatted text.
        Console.WriteLine(text.Trim());
    }
    
    //Converts any string to pascal case.
    private static string StringToPascalCase(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
    
        char[] chars = s.ToCharArray();
        chars[0] = char.ToUpper(chars[0]);
    
        return new string(chars);
    }
}