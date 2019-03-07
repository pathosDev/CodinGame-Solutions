/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: ISBN Check digit             */
/* Difficulty: Easy                     */
/* Date solved: 17.11.2018              */
/*                                      */
/****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int N = int.Parse(Console.ReadLine());

        //Store invalid ISBNs.
        List<string> invalidISBN = new List<string>();

        for (int i = 0; i < N; i++)
        {
            string ISBN = Console.ReadLine();

            //Check if current ISBN is invalid.
            if (!IsValidISBN(ISBN))
            {
                invalidISBN.Add(ISBN);
            }
        }

        //Output invalid ISBN's.
        Console.WriteLine($"{ invalidISBN.Count } invalid:");
        Console.WriteLine(string.Join("\n", invalidISBN));
    }

    //Checks if a given ISBN-10 or ISBN-13 is valid or not.
    private static bool IsValidISBN(string isbn)
    {
        if (isbn.Length == 10) //Check if isbn is ISBN-10.
        {
            return IsValidISBN10(isbn);
        }
        else if (isbn.Length == 13) //Check if isbn is ISBN-13.
        {
            return IsValidISBN13(isbn);
        }

        return false;
    }

    //Checks if a given ISBN-10 is valid or not.
    private static bool IsValidISBN10(string isbn)
    {
        //Check allowed characters.
        if (!Regex.IsMatch(isbn, @"^\d{9}(\d|X)$"))
        {
            return false;
        }

        //Calculating checksum.
        int checkSum = 0;

        for (int i = 0; i < isbn.Length - 1; i++)
        {
            checkSum += (isbn[i] - '0') * (10 - i);
        }

        int checkDigit = (11 - checkSum) % 11;

        if (checkDigit < 0)
        {
            checkDigit += 11;
        }

        int givenCheckDigit = isbn.Last() == 'X' ? 10 : isbn.Last() - '0';

        //Comparing checkdigits.
        return givenCheckDigit == checkDigit;
    }

    //Checks if a given ISBN-13 is valid or not.
    private static bool IsValidISBN13(string isbn)
    {
        //Check allowed characters.
        if (!Regex.IsMatch(isbn, @"^\d{13}$"))
        {
            return false;
        }

        //Calculating checksum.
        int checkSum = 0;

        for (int i = 0; i < isbn.Length - 1; i++)
        {
            checkSum += (isbn[i] - '0') * (i % 2 == 0 ? 1 : 3);
        }

        int checkDigit = (10 - checkSum) % 10;

        if (checkDigit < 0)
        {
            checkDigit += 10;
        }

        int givenCheckDigit = isbn.Last() == 'X' ? 10 : isbn.Last() - '0';

        //Comparing checkdigits.
        return givenCheckDigit == checkDigit;
    }
}