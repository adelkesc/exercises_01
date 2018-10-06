using System;

namespace Exercise_9
{
    public class StringUtility
    {
        // private string text;

        // public StringUtility(string text)
        // {
        //     this.text = text;
        // }

        public string SummarizeText()
        {
            Console.WriteLine("Write something: ");
            string text = Console.ReadLine();

            var stringArray = text.Split(' ');

            for(int index = 0; index < stringArray.Length; index++)
            {
                if(stringArray.Length > 20)
                {
                    string ellipse = string.Join("...", stringArray[21]);
                    return ellipse;
                }
                
            }
            return string.Join(" ", stringArray);

        }
    }
}