/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: ASCII Art                    */
/* Difficulty: Easy                     */
/* Date solved: 17.11.2018              */
/*                                      */
/****************************************/

import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Pattern;

public class Solution
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        int N = Integer.parseInt(scanner.nextLine());

        //Store invalid ISBNs.
        ArrayList<String> invalidISBN = new ArrayList<String>();

        for (int i = 0; i < N; i++)
        {
            String ISBN = scanner.nextLine();

            //Check if current ISBN is invalid.
            if (!isValidISBN(ISBN))
            {
                invalidISBN.add(ISBN);
            }
        }

        //Output invalid ISBN's.
        System.out.println(invalidISBN.size() + " invalid:");
        System.out.println(String.join("\n", invalidISBN));
    }

    //Checks if a given ISBN-10 or ISBN-13 is valid or not.
    private static boolean isValidISBN(String isbn)
    {
        if (isbn.length() == 10) //Check if isbn is ISBN-10.
        {
            return isValidISBN10(isbn);
        }
        else if (isbn.length() == 13) //Check if isbn is ISBN-13.
        {
            return isValidISBN13(isbn);
        }

        return false;
    }

    //Checks if a given ISBN-10 is valid or not.
    private static boolean isValidISBN10(String isbn)
    {
        //Check allowed characters.
        if (!Pattern.matches("^\\d{9}(\\d|X)$", isbn))
        {
            return false;
        }

        //Calculating checksum.
        int checkSum = 0;

        for (int i = 0; i < isbn.length() - 1; i++)
        {
            checkSum += (isbn.charAt(i) - '0') * (10 - i);
        }

        int checkDigit = (11 - checkSum) % 11;
        int givenCheckDigit = isbn.charAt(isbn.length() - 1) == 'X' ? 10 : isbn.charAt(isbn.length() - 1) - '0';

        //Comparing checkdigits.
        return givenCheckDigit == checkDigit;
    }

    //Checks if a given ISBN-13 is valid or not.
    private static boolean isValidISBN13(String isbn)
    {
        //Check allowed characters.
        if (!Pattern.matches("^\\d{13}$", isbn))
        {
            return false;
        }

        //Calculating checksum.
        int checkSum = 0;

        for (int i = 0; i < isbn.length() - 1; i++)
        {
            checkSum += (isbn.charAt(i) - '0') * (i % 2 == 0 ? 1 : 3);
        }

        int checkDigit = (10 - checkSum) % 10;
        int givenCheckDigit = isbn.charAt(isbn.length() - 1) == 'X' ? 10 : isbn.charAt(isbn.length() - 1) - '0';

        //Comparing checkdigits.
        return givenCheckDigit == checkDigit;
    }
}