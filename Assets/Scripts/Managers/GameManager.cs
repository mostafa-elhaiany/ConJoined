using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int totalNumLevels = 4;
    public static bool[] openLevels;

    public static int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        PlayerData data = SaveManager.loadData();
        if(data != null)
        {
            openLevels = data.levels;
        }
        else
        {
            openLevels = new bool[totalNumLevels];
            openLevels[0] = true;
        }

    }

    public static void quitGame()
    {
        Application.Quit();
    }
    public static void saveGame()
    {
        //ToDO handle save game here.
        Debug.Log(currentLevel);
    }
}
