
class Program
{
    // Enum for player states
    enum PlayerState
    {
        NoEnemy,          // 0
        NoPathToEnemy,    // 1
        EngagingEnemy     // 2
    }

    static bool PlayerHasEnemy = true;
    static bool PlayerHasPathToEnemy = false;

    // Function to get current player state
    static PlayerState GetPlayerState()
    {
        if (!PlayerHasEnemy)
        {
            return PlayerState.NoEnemy;
        }

        if (!PlayerHasPathToEnemy)
        {
            return PlayerState.NoPathToEnemy;
        }

        return PlayerState.EngagingEnemy;
    }

    static void Main()
    {
        PlayerState currentState = GetPlayerState();
        Console.WriteLine($"Current Player State: {currentState}");

        // Example of using the enum in logic
        if (currentState == PlayerState.NoEnemy)
        {
            Console.WriteLine("No enemies around. Explore freely!");
        }
        else if (currentState == PlayerState.NoPathToEnemy)
        {
            Console.WriteLine("Enemy detected but path blocked. Find another route.");
        }
        else if (currentState == PlayerState.EngagingEnemy)
        {
            Console.WriteLine("Engaging enemy!");
        }
    }
}
