using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
  
    private LevelModel model;
    private LevelController controller;

    private LevelView view;
    private LevelView2 view2;

    public int[,] map;
    public int mapSize;

    public int level1 = 1;
    public int level2 = 2;
    public int level3 = 3;

    void Start()
    {
        SetMapSize();

        //Model
        model = new LevelModel(mapSize);

        //View 2 tiles...
        view2 = GetComponent<LevelView2>();
        view2.SetModel(model);
        view2.SetMapSize(mapSize);
        view2.SetView();//??
       // view2.SetLevel(map);//??

        //View 1 txt
        view = new LevelView();
        view.SetModel(model);
     
        //Controller
        controller = new LevelController();
        controller.SetModel(model);
        controller.SetView(view);
        controller.SetLevel();
    }

    //this will depend on what determines next level, new scene etc
    public void SetMapSize()
    { 
        if(level1 == 1){
            this.mapSize = 6;
        }
        if (level2 == 2){
            this.mapSize = 8;
        }
        if (level3 == 3){
            this.mapSize = 10;
        }
    }
}
