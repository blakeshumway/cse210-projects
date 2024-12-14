using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description,  int count, List<string> prompts) :base (name, description)
    {
        _count = count;
        _prompts = prompts;
    }



    public void run()
    {

    }


    public void GetRandomPrompt()
    {

    }

    // public List<string> GetListFromUser()
    // {

    // }
        

}