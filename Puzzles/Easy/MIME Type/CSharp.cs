/****************************************/
/*                                      */
/* CodinGame.com Solutions by pathosDev */
/*                                      */
/* Puzzle: MIME Type                    */
/* Difficulty: Easy                     */
/* Date solved: 08.11.2018              */
/*                                      */
/****************************************/

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public static void Main()
    {
        //Read inputs.
        int N = int.Parse(Console.ReadLine());
        int Q = int.Parse(Console.ReadLine());
        
        //Creating hashmap: extension -> mimetype
        Dictionary<string, string> mimeTypes = new Dictionary<string, string>();
        
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            
            string EXTENSION = inputs[0];
            string MIMETYPE = inputs[1];
            
            //Fill the hashmap.
            mimeTypes.Add("." + EXTENSION.ToLower(), MIMETYPE);
        }
        
        for (int i = 0; i < Q; i++)
        {
            string FILENAME = Console.ReadLine();
            string FILEEXT = Path.GetExtension(FILENAME).ToLower();
            
            //Check if the file's extension is known.
            if (mimeTypes.ContainsKey(FILEEXT))
            {
                //Output the corresponding MIME type if file's extension is known.
                Console.WriteLine(mimeTypes[FILEEXT]);
            }
            else
            {
                //Output "UNKNKOWN" if file's extension is not known.
                Console.WriteLine("UNKNOWN");
            }
        }
    }
}