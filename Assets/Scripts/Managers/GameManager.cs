using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static bool[] levelsWon;

    // Start is called before the first frame update
    void Start()
    {
        //load game here
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void quitGame()
    {
        Application.Quit();
    }
    public static void saveGame()
    {
        //ToDO handle save game here.
    }
}
