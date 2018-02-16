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


    public int[,] map { get; set; }

    public int mapSize { get; set; }

    public LevelModel(int mapSize) {
        this.mapSize = mapSize;
        this.map = new int[this.mapSize, this.mapSize];
    }



    public SquareState currentSquareState;
    public int SQUARE;
    public int SQUARE_EMPTY = 1;
    public int SQUARE_MANEOUVORABLE_OBSTACLE = 2;
    public int SQUARE_NON_MANEOUVRABLE_OBSTACLE = 3;
    public int SQUARE_PLAYER = 4;
    public int SQUARE_MANEOUVORABLE_OBSTACLE_PLAYER = 5;

    public void SquareStates(){ 
        switch (currentSquareState){
            case SquareState.SQUARE_EMPTY:
                SQUARE_EMPTY = 1;
                break;
            case SquareState.SQUARE_MANEOUVORABLE_OBSTACLE:
                SQUARE_MANEOUVORABLE_OBSTACLE = 2;
                break;
            case SquareState.SQUARE_NON_MANEOUVRABLE_OBSTACLE:
                SQUARE_NON_MANEOUVRABLE_OBSTACLE = 3;
                break;
            case SquareState.SQUARE_PLAYER:
                SQUARE_PLAYER = 4;
                break;
            case SquareState.SQUARE_MANEOUVORABLE_OBSTACLE_PLAYER:
                SQUARE_MANEOUVORABLE_OBSTACLE_PLAYER = 5;
                break;
        }
    }

    /*
  public void KeyPressTest(){
      if(Input.GetKeyDown(KeyCode.Space)){
          model.currentSquareState = LevelModel.SquareState.SQUARE_EMPTY;
      }

      if (Input.GetKeyDown(KeyCode.M)){
          model.currentSquareState = LevelModel.SquareState.SQUARE_MANEOUVORABLE_OBSTACLE;
      }

      if (Input.GetKeyDown(KeyCode.N)){
          model.currentSquareState = LevelModel.SquareState.SQUARE_NON_MANEOUVRABLE_OBSTACLE;
      }

      if (Input.GetKeyDown(KeyCode.N)){
          model.currentSquareState = LevelModel.SquareState.SQUARE_PLAYER;
      }

      if (Input.GetKeyDown(KeyCode.Space)){
          model.currentSquareState = LevelModel.SquareState.SQUARE_MANEOUVORABLE_OBSTACLE_PLAYER;
      }
  }
  */
}