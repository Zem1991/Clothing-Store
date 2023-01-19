public enum GameState
{
    NORMAL,
    INVENTORY,
    SELL_ITEMS,
    DIALOGUE,
}

public static class GameStateEnum
{
    public static bool IsPlayable(this GameState itemType)
    {
        return itemType == GameState.NORMAL;
    }
}
