using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelView : MonoBehaviour
{
    private LevelController levelcontroller;

    private LevelModel levelModel;

    public GameObject tilePrefab;
    public GameObject blackPrefabTile;
    public GameObject [,] tiles;

    private GameObject newTile;
    private GameObject newBlackTile;

    public Vector3 tilePosition;
    public List<Vector3> positionZ;
    public int mapSize;

    [Range(0, 1)]
    public float tileOutline;

    void Start()
    {
       // DisplayMap(tiles[], x,  y);      
    }

    public void SetModel(LevelModel levelModel)
    {
        this.mapSize = levelModel.GetMapSize();
        this.tiles = new GameObject[mapSize, mapSize];
        this.levelModel = levelModel;
    }


    public void DisplayMap()
    {
        for(int i = 0; i < mapSize; ++i)
        {
            for (int j = 0; j < mapSize; ++j)
            {
                CreateTile( tiles[i,j] ,i ,j);


               // tiles[i,j]= tiles[x,y];
            }
        }

      //  Debug.Log(levelModel.GetMap[,]);

           //CreateTile(x, y);
           //Also grab co-ords on the way?
    }
        
    private void CreateTile(int[,] tiles, int x, int y)
    {
        newTile = (GameObject)Instantiate(tilePrefab) as GameObject;     
       
        //display tile at that position

        Vector3 tilePosition = new Vector3(x + 0.5f, 0.0f, y + 0.5f);

        newTile.transform.position = tilePosition;

        //tiles[x, y] = tilePosition;//index size

        newTile.transform.localScale = Vector3.one * (1 - tileOutline);
        newBlackTile = (GameObject)Instantiate(blackPrefabTile);
        Vector3 blackTilePosition = new Vector3(x + 0.5f, -0.009f, y + 0.5f);
        newBlackTile.transform.position = blackTilePosition;

    }
  //  x + 0.5f, 0.0f, y + 0.5f
 
}

