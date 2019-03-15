/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: How time flies               */
/* Difficulty: Easy                     */
/* Date solved: 05.03.2019              */
/*                                      */
/****************************************/

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;

public class Solution
{
    public static void main(String[] args) throws ParseException
    {
        //Read dates.
        Scanner scanner = new Scanner(System.in);
        
        SimpleDateFormat dateParser = new SimpleDateFormat("dd.MM.yyyy");
        
        long begin = dateParser.parse(scanner.nextLine()).getTime();
        long end = dateParser.parse(scanner.nextLine()).getTime();

        //Calculate result.
        long days = (end - begin) / (1000 * 60 * 60 * 24); 
        int months = new Date(end - begin).getMonth();
        long years = days / 365;

        //Print result.
        if (years > 0)
        {
            System.out.printf("%d year%s, ", years, years > 1 ? "s" : "");
        }

        if (months > 0)
        {
            System.out.printf("%d month%s, ", months, months > 1 ? "s" : "");
        }

        System.out.printf("total %d days", days);
    }
}