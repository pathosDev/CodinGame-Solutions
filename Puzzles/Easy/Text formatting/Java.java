/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Text formatting              */
/* Difficulty: Easy                     */
/* Date solved: 13.11.2018              */
/*                                      */
/****************************************/

import java.util.Arrays;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class Solution
{
    public static void main(String[] args)
    {
        //Read input.
        Scanner scanner = new Scanner(System.in);
        
        String text = scanner.nextLine().toLowerCase().trim();

        //Remove excessive spaces.
        text = text.replaceAll("\\s{2,}", " ");
        
        //Remove spaces before and after punctuations.
        Pattern regexPattern = Pattern.compile("\\s?\\p{P}\\s?");
        Matcher regexMatcher = regexPattern.matcher(text);
        
        while (regexMatcher.find())
        {
            String match = regexMatcher.group();
            text = text.replaceAll(match.replace(".", "\\."), match.trim());
        }
        
        //Remove repeated punctuations.
        regexPattern = Pattern.compile("\\p{P}+");
        regexMatcher = regexPattern.matcher(text);
        
        while (regexMatcher.find())
        {
            String match = regexMatcher.group();
            text = text.replaceAll(match.replace(".", "\\."), match.trim().charAt(0) + "");
        }
        
        //First letter uppercase.
        text = Arrays.stream(text.split("\\.", -1)).map(s -> stringToPascalCase(s)).collect(Collectors.joining("."));

        //Add spaces after punctuations.
        text = text.replaceAll("\\p{P}", "$0 ");

        //Output formatted text.
        System.out.println(text.trim());
    }
    
    //Converts any string to pascal case.
    private static String stringToPascalCase(String s)
    {
        if (s == null || s.isEmpty())
        {
            return "";
        }
    
        char[] chars = s.toCharArray();
        chars[0] = Character.toUpperCase(chars[0]);
    
        return new String(chars);
    }
}