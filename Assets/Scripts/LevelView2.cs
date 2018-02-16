using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelView2 : MonoBehaviour {

    private LevelModel model;
    private LevelView view;
    private LevelController controller;

    private GameObject _newTile;
    private GameObject _man_tile;
    private GameObject _non_man_tile;

    public GameObject tilePrefab;
    public GameObject man_tile;
    public GameObject non_man_tile;

    public int mapSize;
    private int[,] map;

    public void SetModel(LevelModel model)
    {
        this.model = model;
    }

   // void Start()
   // {
   //  
   // }

   // void Update()
   // {
   //   
   // }

    public void SetMapSize(int mapSize)
    {
        this.mapSize = mapSize;
    }

    public void SetView()
    { 
        for (int x = 0; x < model.map.GetLength(0); x++)
        {
            for (int y = 0; y < model.map.GetLength(1); y++)
            {    
                if (model.map[x, y] == 0){CreateTile(x, y);}
                if (model.map[x, y] == 1){CreateTile(x, y);}
                if (model.map[x, y] == 2){CreateTile(x, y);}
                if (model.map[x, y] == 3){CreateTile(x, y);}
                if (model.map[x, y] == 4){CreateTile(x, y);}
            }
        }
    }

    public void CreateTile(int x, int y)
    {
        _newTile = (GameObject)Instantiate(tilePrefab) as GameObject;
        _man_tile = (GameObject)Instantiate(man_tile) as GameObject;
        _non_man_tile = (GameObject)Instantiate(non_man_tile) as GameObject;
        Vector3 tilePosition = new Vector3(x + 0.5f, 0.0f, y + 0.5f);

        if (model.map[x, y] == 0)
        {         
            _newTile.transform.position = tilePosition;  
        }

        else if(model.map[x, y] == 1)
        {  
            _man_tile.transform.position = tilePosition;   
        }

        else if (model.map[x, y] == 2)
        {   
            _non_man_tile.transform.position = tilePosition; 
        }
    }
}
