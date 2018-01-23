using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelView : MonoBehaviour
{   
     /// <summary>
     /// instantiating object
     /// </summary>
    public GameObject tilePrefab;

    //public GameObject tileContainerGO;

    /// <summary>
    /// instantiating object
    /// </summary>
    private LevelModel levelModel;

    /// <summary>
    /// initializing variables
    /// </summary>
    public int mapSize;

    /// <summary>
    /// instantiating object array
    /// </summary>
    public GameObject[,] tiles;

    /// <summary>
    /// instantiating variables
    /// </summary>
    public float tileOutline;

    /// <summary>
    /// instantiating object
    /// </summary>
    public GameObject tileClones;

    /// <summary>
    /// instantiating vector position
    /// </summary>
    List<Vector3> positionZ;
    //public Vector3[] tilePositions;

    /// <summary>
    /// instantiating variables
    /// </summary>
    GameObject newTile;

    /// <summary>
    /// instantiating object
    /// </summary>
    Vector3 tilePosition;

    /// <summary>
    /// On Start - display map
    /// </summary>
    void Start()
    {
        DisplayMap();  
    }


    /// <summary>
    /// Setting map to specific size  X x Y
    /// </summary>
    public void SetModel(LevelModel levelModel)
    {
        this.mapSize = levelModel.GetMapSize();
        this.tiles = new GameObject[mapSize,mapSize];
        this.levelModel = levelModel;
    }

    /// <summary>
    /// Display the map
    /// </summary>
    public void DisplayMap()
    {
        for (int x=0; x < mapSize; x++)
        {
            for (int y=0; y < mapSize; y++)
            {
                CreateTile(x,y);
            }
        }
    }

    /// <summary>
    /// Set clones to parent 
    /// </summary>
    public void SetParent(GameObject TileClones2)
    {
        newTile.transform.parent= TileClones2.transform;
    }

    /// <summary>
    /// Create tiles from prefab
    /// </summary>
    private void CreateTile(int x, int y)
    {
        newTile = (GameObject)Instantiate(tilePrefab) as GameObject;
        Vector3 tilePosition = new Vector3(x + 0.5f, 0, y + 0.5f);
        newTile.transform.position = tilePosition;
        //SetParent(findTileClones);
        // newTile.localScale = Vector3.one * (1 - tileOutline);
       // newTile.transform.parent = tileContainerGO.transform;
    }

    /// <summary>
    /// Destroy tile clones
    /// </summary>
    public void DestroyTiles()
    {
        var clones = GameObject.FindGameObjectsWithTag("clone");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
    }

    /// <summary>
    /// Find the position of tile
    /// </summary>
    void positionOfTile()
    {
      var  tilePosition = GameObject.FindGameObjectsWithTag("clone");
        foreach (var pos in tilePosition)
        {
           // tilePositions[pos];
        }
    }
}

