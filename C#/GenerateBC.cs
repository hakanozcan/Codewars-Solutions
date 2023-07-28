//4 kyu
//https://www.codewars.com/kata/563fbac924106b8bf7000046
using System;
using System.Linq;

public class Kata {

 public static string GenerateBC(string url, string separator)
        {
            var wordsExclude = new[] {"THE", "OF", "IN", "FROM", "BY", "WITH", "AND", "OR", "FOR", "TO", "AT", "A"};
            var urlParts = new Uri(new UriBuilder(url).ToString()).Segments.Skip(1).Where(x => !x.Contains("index."));

            return string.Join(separator, urlParts.Select(s => s.Split('.')[0].TrimEnd('/').ToUpper()).Prepend("HOME")
                .Select((s, i) => new
                {
                    href = string.Concat(urlParts.Take(i)),
                    text = s.Length > 30
                        ? string.Concat(s.Split('-').Where(w => !wordsExclude.Contains(w)).Select(c => c[0]))
                        : s.Replace("-", " ")
                }).Select((x, i) =>
                    i < urlParts.Count()
                        ? $"<a href=\"/{x.href}\">{x.text}</a>"
                        : $"<span class=\"active\">{x.text}</span>"));
        }

}