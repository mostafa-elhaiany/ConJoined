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
}
