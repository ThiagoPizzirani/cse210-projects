using System.Transactions;

public class Video
{
     public string _title;
    public string _author;
    public double _lenght;

    public List<Comment> _comments = new List<Comment>();
   
    
    public void AddComment(Comment comment)
    {
       _comments.Add(comment);
    }

       public int TotalComments()
    {
        return _comments.Count();
    }


}