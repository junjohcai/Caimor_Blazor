namespace MyBlazorApp.Models;

public class Account
{
    public int Id { get; set; }
    public string Username { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public List<Vehicle> FavoriteVehicles { get; set; } = new List<Vehicle>();
}