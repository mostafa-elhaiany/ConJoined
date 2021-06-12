using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneHandler //: MonoBehaviour
{

    public static void changeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public static void levelWon()
    {
        //ToDo
        // set levels won in game manager
        //save game
        SceneManager.LoadScene("YouWin");
    }
}
