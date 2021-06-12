using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandlerScript : MonoBehaviour
{
    [SerializeField]
    Button quitButton;

    [SerializeField]
    ButtonScene[] SceneChangers;


    // Start is called before the first frame update
    void Start()
    {
        foreach(ButtonScene buttonScene in SceneChangers)
        {
            buttonScene.button.onClick.AddListener(delegate { buttonClicked(buttonScene.scene); });
        }
        if(quitButton != null)
            quitButton.onClick.AddListener(quitGame);
    }
    public void quitGame()
    {
        GameManager.quitGame();
    }

    
    public void buttonClicked(string scene)
    {
        SceneHandler.changeScene(scene);
    }
}
