public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length} seconds, Comment Count:{GetCommentCount()}");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public int GetCommentCount()
    {
        int listCount = _comments.Count;
        return listCount;
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);

        _comments.Add(comment);

    }

}
