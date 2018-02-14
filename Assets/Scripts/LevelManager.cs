using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
  
    private LevelModel model;
    private LevelView view;
    private LevelController controller;

    private GameObject newTile;
    public GameObject tilePrefab;

    public int[,] map;
    public int mapSize;

	void Start () {
  
    }






    public void CreateTile(int x, int y)
    {
        newTile = (GameObject)Instantiate(tilePrefab) as GameObject;
        Vector3 tilePosition = new Vector3(x + 0.5f, 0.0f, y + 0.5f);
        newTile.transform.position = tilePosition;
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
