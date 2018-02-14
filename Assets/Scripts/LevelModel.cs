
public class LevelModel 
{
    public enum SquareState
    {
        SQUARE_EMPTY,
        SQUARE_MANEOUVORABLE_OBSTACLE,
        SQUARE_NON_MANEOUVRABLE_OBSTACLE,
        SQUARE_PLAYER,
        SQUARE_MANEOUVORABLE_OBSTACLE_PLAYER
    };

    public SquareState currentSquareState;

    public int[,] map { get; set; }

    public int mapSize { get; set; }

    public LevelModel(int mapSize){
        this.mapSize = mapSize;
        this.map = new int[this.mapSize, this.mapSize];
    }
     
    public void StartStateSquare()
    {
        currentSquareState = SquareState.SQUARE_EMPTY;
    }

    public void SquareStates(){ 
        switch (currentSquareState){
            case SquareState.SQUARE_EMPTY:
             
                break;
            case SquareState.SQUARE_MANEOUVORABLE_OBSTACLE:
             //   Debug.Log("Suqare Man Obstacle");
                break;
            case SquareState.SQUARE_NON_MANEOUVRABLE_OBSTACLE:
            //    Debug.Log("Suqare Non Man Obstalce");
                break;
            case SquareState.SQUARE_PLAYER:
             //   Debug.Log("Suqare Player");
                break;
            case SquareState.SQUARE_MANEOUVORABLE_OBSTACLE_PLAYER:
             //   Debug.Log("Suqare Man Obstacle Player");
                break;
        }
    }
 


}