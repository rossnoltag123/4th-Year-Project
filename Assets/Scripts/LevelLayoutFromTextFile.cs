using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelLayoutFromTextFile {

    public string levelLayOutString;            //After ReadTextFile() has been called, this string will equal the text file text in a string,
    public string[] levelLayOutArrayRead;       //this array will hold the string broken into single characters for editing.
    public string[] levelLayOutArrayWrite;      //In the case of updating the text-file for the display.
    public int startPosition;

    public void ReadTextFile()
    {        
        string path = "Assets/Resources/LevelDesign.txt";                   //Assign Path to text file

        StreamReader reader = new StreamReader(path);                       //(path) is passed to StreamReaded to read in 

        levelLayOutString = reader.ReadToEnd().ToString();                  //Convert the text file to a string

        levelLayOutArrayRead = levelLayOutString.Split(' ');                //Split the string into an array for changing position.                                                                 
        levelLayOutArrayWrite = levelLayOutString.Split(' ');

        levelLayOutString = string.Join(" ", levelLayOutArrayWrite);        //Convert back to string for display

        reader.Close();
    }

    ///////////////////////////////////TestScene/////////////////////////////////////////////  
    // Writing to the text file will "update the map", this will give the impression that the player
    // is moving across the board.
    //Work in progress.....
    public void WriteString(string [] s,int y,int z)
    { 
        string player;
        string destination;

        int aPlayer = 8;
        int bDestination;
        Debug.Log("Before Test" + levelLayOutString);
        string path = "Assets/Resources/LevelDesign.txt";

        StreamWriter writer = new StreamWriter(path, true);


        for (int i = 0; i < s.Length; i++)
        {
            player = s[y];//8
            destination = s[z];//0

            int.TryParse(player, out aPlayer);
            int.TryParse(destination, out bDestination);

            s[z]= aPlayer.ToString();//New Destination= 8(Where player is)
            s[y] = bDestination.ToString();//Old Destination = 0(Where player was)

            //changed the array, now need to change string for text file
                                
        }

        levelLayOutString = s.ToString();
        Debug.Log("After Test"+levelLayOutString);

      //  writer.WriteLine("Test");
        writer.Close();
    }
    
   
    public void UpdateTextDisplay(int y)
    {   
        string playerPosition= levelLayOutArrayWrite[0];

        string newPlayrPosition= levelLayOutArrayWrite[y];

        playerPosition = levelLayOutArrayWrite[y];
           
        Debug.Log("player position" + levelLayOutArrayWrite[0]);

        //Debug.Log("new player position" + levelLayOutArrayWrite[y]);
                                                                           
        levelLayOutString = string.Join(" ", levelLayOutArrayWrite);    
      
        Debug.Log(levelLayOutString);           
    }

}
