using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChepragaDM.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            
            string content = File.ReadAllText(path);

           
            content = content.Replace(".", " ")
                             .Replace(",", " ")
                             .Replace("!", " ")
                             .Replace("?", " ")
                             .Replace(";", " ")
                             .Replace(":", " ")
                             .Replace("(", " ")
                             .Replace(")", " ")
                             .Replace("[", " ")
                             .Replace("]", " ")
                             .Replace("{", " ")
                             .Replace("}", " ");

           
            string[] words = content.Split(new char[] { ' ', '\r', '\n', '\t' },
                                          StringSplitOptions.RemoveEmptyEntries);

            string result = "";

            foreach (string word in words)
            {
            
                if (word.ToLower().Contains('n'))
                {
                    if (result.Length > 0)
                    {
                        result += " ";
                    }
                    result += word;
                }
            }

            return result;
        }
    }
}
