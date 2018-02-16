public class LevelView 
{
    private LevelController controller;
    private LevelModel model;
    private LevelManager manager;

    private int [,] map;
    private int mapSize;

    public void SetModel(LevelModel model)
    {    
         this.model = model;
    }

    public void SetController(LevelController controller)
    {
        this.controller = controller;
    }

    public void SetView(int mapSize)
    {
        this.mapSize = mapSize;
    }

    public void UpdateView()
    {
        this.map = model.map;
    }

}

 


