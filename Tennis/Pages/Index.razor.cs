using System.Numerics;
using Tennis.DataAccess.Models;

namespace Tennis.Pages;

public partial class Index
{
	public Player PlayerA { get; set; } = new() { Name = "Player A" };
	public Player PlayerB { get; set; } = new() { Name = "Player B" };

	public string[] ScoreTypes { get; set; } = new[] { "Love", "15", "30", "40", "game" };

	public bool APlayerWonWithoutGameGoingIntoDouce()
	{
		if (PlayerA.Points > 3 || PlayerB.Points > 3)
		{
			if (PlayerA.Points <= 2 || PlayerB.Points <= 2)
			{
				return true;
			}
		}
		return false;
	}

	public bool APlayerWonAfterGameWentIntoDouce()
	{
		if (PlayerA.Points > 3 || PlayerB.Points > 3)
		{
			if (PlayerA.Points >= PlayerB.Points + 2 || PlayerB.Points >= PlayerA.Points + 2)
			{
				return true;
			}
		}

		return false;
	}

	public bool IsItDouce()
	{
		if (PlayerA.Points >= 3 && PlayerB.Points >= 3 && PlayerA.Points == PlayerB.Points)
		{
			return true;
		}

		return false;
	}

	public bool APlayerHasAdvantage()
	{
		if (PlayerA.Points >= 3 && PlayerB.Points >= 3)
		{
			if (PlayerA.Points == PlayerB.Points + 1 || PlayerB.Points == PlayerA.Points + 1)
			{
				return true;
			}
		}

		return false;
	}

	public bool APlayerWonSetAfterSixGameWinsWithTwoOrMoreGameWins()
	{
		if (PlayerA.Games == 6 || PlayerB.Games == 6)
		{
			if (PlayerA.Games >= PlayerB.Games + 2 || PlayerB.Games >= PlayerA.Games + 2)
			{
				return true;
			}
		}

		return false;
	}

	public bool APlayerWonSetAfterTieBreak()
	{
		return PlayerA.Games == 7 || PlayerB.Games == 7;
	}

	public bool APlayerWonMatchWithTwoMoreSetWins()
	{
		if (PlayerA.Sets >= PlayerB.Sets + 2 || PlayerB.Sets >= PlayerA.Sets + 2)
		{
			return true;
		}

		return false;
	}

	public bool APlayerWonMatchAfterThreeSetWins()
	{
		if (PlayerA.Sets == 3 || PlayerB.Sets == 3)
		{
			return true;
		}
		return false;
	}

	public Player PlayerWithMostPoints()
	{
		if (PlayerA.Points > PlayerB.Points)
		{
			return PlayerA;
		}

		return PlayerB;
	}

	public Player PlayerWithMostGameWinsDuringASet()
	{
		if (PlayerA.Games > PlayerB.Games)
		{
			return PlayerA;
		}

		return PlayerB;
	}

	public Player PlayerWithMostSetWins()
	{
		if (PlayerA.Sets > PlayerB.Sets)
		{
			return PlayerA;
		}

		return PlayerB;
	}

	public void PlayerAWinsAPoint()
	{
		PlayerA.Points++;
	}

	public void PlayerBWinsAPoint()
	{
		PlayerB.Points++;
	}

	public void ResetPoints()
	{
		PlayerA.Points = 0;
		PlayerB.Points = 0;
	}
	public void ResetGames()
	{
		PlayerA.Games = 0;
		PlayerB.Games = 0;
	}
	public void Reset()
	{
		PlayerA = new Player() { Name = "Player A" };
		PlayerB = new Player() { Name = "Player B" };
	}
}