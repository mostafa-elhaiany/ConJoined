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
        if (GameManager.currentLevel < GameManager.openLevels.Length-1)
            GameManager.openLevels[GameManager.currentLevel+1] = true;
        //save game
        SaveManager.saveData();
        SceneManager.LoadScene("YouWin");
    }
}
