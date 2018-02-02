using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController 
{

    public LevelModel levelModel;

    private LevelView theView;

    public LevelController(LevelModel levelModel, LevelView theView)
    {
        this.theView = theView;
        this.levelModel = levelModel;

    }
    
    /*
    private LevelModel levelModel;

    private LevelView levelView;

    public LevelController(LevelModel levelModel, LevelView levelView)
    {
        this.levelView = levelView;
        this.levelModel = levelModel;

    }
    */
}
