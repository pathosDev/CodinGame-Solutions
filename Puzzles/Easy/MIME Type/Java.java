/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: MIME Type                    */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

import java.util.HashMap;
import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        //Read inputs.
        Scanner scanner = new Scanner(System.in);
        
        int N = Integer.parseInt(scanner.nextLine());
        int Q = Integer.parseInt(scanner.nextLine());
        
        //Creating hashmap: extension -> mimetype
        HashMap<String, String> mimeTypes = new HashMap<String, String>();
        
        for (int i = 0; i < N; i++)
        {
            String[] inputs = scanner.nextLine().split(" ");
            
            String EXTENSION = inputs[0];
            String MIMETYPE = inputs[1];
            
            //Fill the hashmap.
            mimeTypes.put(EXTENSION.toLowerCase(), MIMETYPE);
        }
        
        for (int i = 0; i < Q; i++)
        {
            String FILENAME = scanner.nextLine();
            String FILEEXT = GetFileExtension(FILENAME).toLowerCase();
            
            //Check if the file's extension is known.
            if (mimeTypes.containsKey(FILEEXT))
            {
                //Output the corresponding MIME type if file's extension is known.
                System.out.println(mimeTypes.get(FILEEXT));
            }
            else
            {
                //Output "UNKNKOWN" if file's extension is not known.
                System.out.println("UNKNOWN");
            }
        }
    }
    
    //Gets a file's extension without the dot itself. If the file has no extension it will return "".
    private static String GetFileExtension(String file)
    {
        //Find the beginning of an extension.
        int extensionIndex = file.lastIndexOf('.');
        
        if (extensionIndex < 0)
        {
            //There is no extension.
            return "";
        }
        
        return file.substring(extensionIndex + 1);
    }
}