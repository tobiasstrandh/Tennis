namespace Tennis.DataAccess.Models;

public class Player
{
	public string Name { get; set; } = string.Empty;
	public int Points { get; set; }
	public int Games { get; set; }
	public int Sets { get; set; }
}