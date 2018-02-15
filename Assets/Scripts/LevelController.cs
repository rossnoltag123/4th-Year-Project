using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController 
{
    public LevelModel model;
    public LevelView view;

    public int[,] map;
    public int mapSize; 
  

    public void SetModel(LevelModel model){
       model = new LevelModel(this.mapSize);         
    }

    public void SetView(LevelView view){
        this.view = view; 
    }

    public void DisplayArray(){

    }
 
}
