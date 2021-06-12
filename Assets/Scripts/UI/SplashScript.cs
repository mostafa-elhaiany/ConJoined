using UnityEngine;

public class SplashScript : MonoBehaviour
{
    [SerializeField]
    float waitTime=5f;

    [SerializeField]
    string scene="Main Menu";

    float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
            SceneHandler.changeScene(scene);
        
    }
}
