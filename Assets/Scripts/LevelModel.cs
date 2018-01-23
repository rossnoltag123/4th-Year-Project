public class LevelModel
{
    /// <summary>
    /// Numbering tiles to be used
    /// </summary>
    public enum SquareType
    {/// <summary>
    /// 
    /// </summary>
        EMPTY,
        ONE_TALL,
        TWO_TALL,
        THREE_TALL
    };

    /// <summary>
    ///initialising array for map
    /// </summary>
    private int[,] map;

    /// <summary>
    /// initializing map size
    /// </summary>
    private int mapSize;

    /// <summary>
    /// This class constructor
    /// </summary>
    public LevelModel(int mapSize)
    {
        this.mapSize = mapSize;
        this.map = new int[this.mapSize, this.mapSize];
    }

    /// <summary>
    /// Get map method
    /// </summary>
    public int[,] GetMap()
    {
        return this.map;
    }

    /// <summary>
    /// Get map size method
    /// </summary>
    public int GetMapSize()
    {
        return mapSize;
    }

}
