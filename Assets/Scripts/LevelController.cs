public class LevelController 
{
    public LevelModel model;
    public LevelView view;

    private int[,] map;
  
  
    public void SetModel(LevelModel model){
        this.model = model;
    }

    public void SetView(LevelView view){
        this.view = view; 
    }

    public void SetLevel()
    {
        if (model.mapSize == 6) {
          //  model.mapSize = mapSize;
            model.map[2, 2] = model.SQUARE_MANEOUVORABLE_OBSTACLE;
            model.map[2, 3] = model.SQUARE_NON_MANEOUVRABLE_OBSTACLE;
            model.map[2, 4] = model.SQUARE_MANEOUVORABLE_OBSTACLE;
            model.map[2, 5] = model.SQUARE_PLAYER;
        }

        if (model.mapSize == 8) {
            model.map[2, 1] = model.SQUARE_MANEOUVORABLE_OBSTACLE; ;
            model.map[2, 2] = model.SQUARE_MANEOUVORABLE_OBSTACLE;
            model.map[2, 3] = model.SQUARE_NON_MANEOUVRABLE_OBSTACLE;
            model.map[2, 4] = model.SQUARE_MANEOUVORABLE_OBSTACLE;
            model.map[2, 5] = model.SQUARE_PLAYER;
        }

        if (model.mapSize == 10) {
            model.map[2, 1] = model.SQUARE_MANEOUVORABLE_OBSTACLE; ;
            model.map[2, 2] = model.SQUARE_MANEOUVORABLE_OBSTACLE;
            model.map[2, 3] = model.SQUARE_NON_MANEOUVRABLE_OBSTACLE;
            model.map[2, 4] = model.SQUARE_MANEOUVORABLE_OBSTACLE;
            model.map[2, 5] = model.SQUARE_MANEOUVORABLE_OBSTACLE;
            model.map[2, 6] = model.SQUARE_PLAYER;
        }
    }
   
}
