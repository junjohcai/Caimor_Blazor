namespace MyBlazorApp.Models;

public abstract class Review 
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = "";
    public DateTime DateSubmitted { get; set; }

    public void SubmitReview() 
    {
        DateSubmitted = DateTime.Now;
    }
}