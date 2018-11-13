/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: Bulk Email Generator         */
/* Difficulty: Easy                     */
/* Date solved: 12.11.2018              */
/*                                      */
/****************************************/

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Solution
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        int N = Integer.parseInt(scanner.nextLine());

        String[] emailTemplateLines = new String[N];

        for (int i = 0; i < N; i++)
        {
            emailTemplateLines[i] = scanner.nextLine();
        }

        String emailTemplate = String.join("\n", emailTemplateLines);

        //Create regex objects.
        Pattern regexPattern = Pattern.compile("\\([^)]*\\)");
        Matcher regexMatcher = regexPattern.matcher(emailTemplate);
        
        int choicesCounter = -1;
        String email = "";
        int emailTemplateIndex = 0;
        
        //Replacing choices.
        while (regexMatcher.find())
        {
            choicesCounter++;
            
            email += emailTemplate.substring(emailTemplateIndex, regexMatcher.start());
            emailTemplateIndex = regexMatcher.end();
            
            String[] choices = emailTemplate.substring(regexMatcher.start() + 1, regexMatcher.end() - 1).split("\\|", -1);
            email += choices[choicesCounter % choices.length];
        }

        email += emailTemplate.substring(emailTemplateIndex);

        //Output email.
        System.out.println(email);
    }
}