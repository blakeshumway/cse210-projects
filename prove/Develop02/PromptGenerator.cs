using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class PromptGenerator
{
    //create list
     public List<string> _prompts;
     public int _randomNumber;

    
    public string GetRandomPrompt()
    {
        return _prompts[_randomNumber];
    }
}