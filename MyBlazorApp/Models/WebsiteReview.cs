namespace MyBlazorApp.Models;

public class WebsiteReview : Review 
{
    public string FeedbackCategory { get; set; } = "";
    public string PlatformType { get; set; } = "";
    public string PageUrl { get; set; } = "";

    public void RouteToDepartment()
    {
        // Example: If FeedbackCategory == "Technical Bug", send to Tech Team
    }

    public bool EscalateToSupport()
    {
        // Example: Trigger support ticket if it's a 1-star review mentioning a broken system
        if (Rating == 1 && Comment.Contains("broken"))
        {
            return true;
        }
        return false;
    }
}