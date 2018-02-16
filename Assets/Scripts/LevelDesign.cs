using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDesign : MonoBehaviour {

    private LevelModel model;
    public LevelController controller;
    public LevelModel.SquareState currentSquareState;
    private LevelManager manager;

    private GameObject newTile;
    public GameObject tilePrefab;

    private int SQUARE_EMPTY = 1 ;
    private int SQUARE_MANEOUVORABLE_OBSTACLE = 2;
    private int SQUARE_NON_MANEOUVRABLE_OBSTACLE = 3;
    private int SQUARE_PLAYER = 4;
    private int SQUARE_MANEOUVORABLE_OBSTACLE_PLAYER = 5;

    private int[,] mapSizeLevelOne = new int[6,6];
    private int[,] mapSizeLevelTwo = new int[8,8];
    private int[,] mapSizeLevelThree = new int[10,10];

    private int mapSize;
    private int[,] map;

  //  public void SetModel(LevelModel model) {
  //      this.model = model;
  //      this.mapSize = model.mapSize;
  //      this.map = model.map;
 //   }

 //   public void SetLevelManager(LevelManager manager){
 //       this.manager = manager;
 //   }

    void Start(){
        LevelOne();
        DisplayLevel(mapSizeLevelOne);
    }

    public void LevelOne() {
        mapSize = 6;
        map = mapSizeLevelOne;
        mapSizeLevelOne[2, 2] = SQUARE_MANEOUVORABLE_OBSTACLE;
        mapSizeLevelOne[2, 3] = SQUARE_NON_MANEOUVRABLE_OBSTACLE;
        mapSizeLevelOne[2, 4] = SQUARE_MANEOUVORABLE_OBSTACLE;
        mapSizeLevelOne[2, 5] = SQUARE_PLAYER;
    }

    public void LevelTwo(int mapSize)
    {
        this.mapSize = mapSize;
        map = mapSizeLevelTwo;
        mapSizeLevelTwo[2, 2] = SQUARE_MANEOUVORABLE_OBSTACLE;
        mapSizeLevelTwo[2, 3] = SQUARE_NON_MANEOUVRABLE_OBSTACLE;
        mapSizeLevelTwo[2, 4] = SQUARE_MANEOUVORABLE_OBSTACLE;
        mapSizeLevelTwo[2, 5] = SQUARE_PLAYER;
    }

    public void LevelScene()
    {
     //   if (Application.loadedLevel = 0)
   //     {

    //    }
    }

    public void DisplayLevel(int [,]mapX){
        for ( int x = 0; x < mapX.GetLength(0); x++){      
            for (int y = 0; y < mapX.GetLength(1); y++){   
                if (mapX[x, y] == 0) { CreateTile(x, y); }    
                if (mapX[x, y] == 1) { CreateTile(x, y); }     
                if (mapX[x, y] == 2) { CreateTile(x, y); }     
                if (mapX[x, y] == 3) { CreateTile(x, y); }     
                if (mapX[x, y] == 4) { CreateTile(x, y); }
            }
        }
    }

    public void CreateTile(int x, int y){
        newTile = (GameObject)Instantiate(tilePrefab) as GameObject;
        Vector3 tilePosition = new Vector3(x + 0.5f, 0.0f, y + 0.5f);
        newTile.transform.position = tilePosition;
    }

    /*   
    0 1 2 3 4 5 6 
    0  x x x x x x x
    1  x x x x x x x
    2  x x o x x x x
    3  x x 0 x x x x
    4  x x o x x x x
    5  x x P x x x x
    6  x x x x x x x
    */

    //tiletype.transform.localScale += new Vector3(1f, 1f, 10f);
    //  public void DisplayMap()
    // {
    //    for (int x = 0; x < mapSizeLevelOne.GetLength(1); ++x)
    //   {
    //      for (int y = 0; y < mapSizeLevelOne.GetLength(0); ++y)
    //     {
    //         CreateTile(x, y);
    //    }
    // }
    //  }

    //   newTile.transform.localScale = Vector3.one* (1 - tileOutline);
    // newBlackTile = (GameObject) Instantiate(blackPrefabTile);
    //  Vector3 blackTilePosition = new Vector3(x + 0.5f, -0.009f, y + 0.5f);
    // newBlackTile.transform.position = blackTilePosition;
}
