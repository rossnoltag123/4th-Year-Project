using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController 
{
    /// <summary>
    /// This is instantiating Level Model class
    /// </summary>
    private LevelModel theModel;

    /// <summary>
    /// This is instantiating Level View class
    /// </summary>
    private LevelView theView;

    /// <summary>
    /// This is the constuctor for this class
    /// </summary>
    public LevelController(LevelModel theModel, LevelView theView)
    {
        this.theView = theView;
        this.theModel = theModel;

    }

	

}
