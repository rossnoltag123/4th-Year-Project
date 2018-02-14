using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelView 
{
    private LevelController controller;
    private LevelModel model;

    public int [,] map;
    public int mapSize;

    public void SetModel(LevelModel model)
    {    
         this.model = model;
    }

    public void Refresh()
    {   //to be updated
        controller.DisplayArray();
    }
        
    
}

