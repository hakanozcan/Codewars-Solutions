using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
public class StripCommentsSolution
{
        public static string StripComments(string text, string[] commentSymbols)
        {
            var commentChars = commentSymbols.SelectMany(s => s.Select(c => c)).ToArray();
            var list = new List<string>();
            foreach (var line in text.Split('\n'))
            {
                var index = line.IndexOfAny(commentChars);
                if (index == -1)
                    list.Add(line.TrimEnd());
                else
                    list.Add(line.Substring(0, index).TrimEnd());
            }
            return string.Join("\n", list);
        }
}