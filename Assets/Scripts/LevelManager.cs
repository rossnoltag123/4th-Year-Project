﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private LevelModel model;
    private LevelController controller;
    private LevelView view;
    private LevelLayoutFromTextFile textFile;

    //private LevelView2 view2
    public Text screenTextLevel;

    void Start()
    {
        //Text File Class
        textFile = new LevelLayoutFromTextFile();
        textFile.ReadTextFile();
   
        //model
        model = new LevelModel(18);

        // Controller
        controller = new LevelController();
        controller.SetModel(model);
        controller.SetView(view);
  
        // View 
        view = new LevelView();
        // view.SetModel(model);
        view.Refresh();

        DisplayTextLevel();
    }

    public void DisplayTextLevel() { screenTextLevel.text = textFile.levelLayOutString; }

    ////////////////////////////////////TEST SCENE////////////////////////////////
    //This button is being used to add 1, it will update display
    // giving the effect of the player moving accross the "board".
    // Work in progress......
    public void ClickButtonMove()
    {
        int y=0;
        textFile.UpdateTextDisplay(y);
        y++;
        Debug.Log("Y"+y);
    }

}