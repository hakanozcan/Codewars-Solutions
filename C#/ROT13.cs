//5 kyu
//https://www.codewars.com/kata/52223df9e8f98c7aa7000062

using System;

public class Kata
{
  private static readonly string ALPHABET = "abcdefghijklmnopqrstuvwxyz";
  private static readonly string CAPS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
  
  public static string Rot13(string message)
  {
    string result = "";
    foreach (char c in message)
    {
      if (ALPHABET.Contains(c))
      {
        int index = ALPHABET.IndexOf(c);
        result += ALPHABET[(index + 13) % ALPHABET.Length];
      }
      else if (CAPS.Contains(c))
      {
        int index = CAPS.IndexOf(c);
        result += CAPS[(index + 13) % CAPS.Length];
      }
      else
      {
        result += c;
      }
    }
    return result;
  }
}