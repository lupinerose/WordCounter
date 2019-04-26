using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _wordInput;
    private string _sentenceInput;
    private static char[] _alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 't', 'r', 's', 'u', 'v', 'w', 'x', 'y', 'z'};

    public RepeatCounter(string wordInput, string sentenceInput)
    {
      _wordInput = wordInput;
      _sentenceInput = sentenceInput;
    }

    public string GetWordInput()
    {
      return _wordInput;
    }

    public string GetSentenceInput()
    {
      return _sentenceInput;
    }

    public char[] GetAlphabet()
    {
      return _alphabet;
    }

    public char[] ToCharArray(string userInput)
    {
      char[] userInputCharArray = userInput.ToCharArray();
      return userInputCharArray;
    }

    public bool IsInputValid(char[] userInput)
    {
      for (int i = 0; i < userInput.Length; i++)
      {
        for (int j = 0; j < _alphabet.Length; j++)
        {
          if (userInput[i] != _alphabet[i])
          {
            return false;
          }
        }
      }
      return true;
    }

  }
}
