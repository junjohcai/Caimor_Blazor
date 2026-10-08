namespace MyBlazorApp.Models;

public class Account
{
    public int Id { get; set; }
    public string Username { get; set; } = "";
    public string PasswordHash { get; private set; } = ""; 
    
    public List<Vehicle> FavoriteVehicles { get; set; } = new List<Vehicle>();
    public void UpdatePassword(string newHashedPassword)
    {
        PasswordHash = newHashedPassword;
    }
}