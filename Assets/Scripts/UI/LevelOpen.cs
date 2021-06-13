using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelOpen : MonoBehaviour
{
    [SerializeField]
    int level;
    [SerializeField]
    GameObject butt;


    private void Start()
    {
        butt.SetActive(GameManager.openLevels[level]);
        GetComponent<Button>().onClick.AddListener(buttonClicked);
    }

    void buttonClicked()
    {
        GameManager.currentLevel = level;
        string level_name = "Level " + level;
        SceneHandler.changeScene(level_name);
    }

}
