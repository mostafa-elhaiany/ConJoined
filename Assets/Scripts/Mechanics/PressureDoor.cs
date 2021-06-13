using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureDoor : MonoBehaviour
{
    [SerializeField]
    bool doorOpened = false;

    [SerializeField]
    Transform closedPosition;
    [SerializeField]
    Transform openedPosition;

    Vector2 position;

    bool played = false;

    [SerializeField]
    float moveValue = 0.1f;

    AudioSource audioSrc;


    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }
    IEnumerator resetSrc()
    {
        yield return new WaitForSeconds(1);
        played = false;
    }

    public void toggleState()
    {
        doorOpened = !doorOpened;
    }

    void Update()
    {
        if (doorOpened)
            position = openedPosition.position;
        else
            position = closedPosition.position;

        Vector2 curPosition = new Vector2(this.transform.position.x, this.transform.position.y);
        if(this.transform.position.x != curPosition.x && this.transform.position.y != curPosition.y && !played)
        {
            played = true;
            audioSrc.Play();
            StartCoroutine("resetSrc");
        }
        
        this.transform.position = Vector2.Lerp(curPosition, position, moveValue * Time.deltaTime);

    }
}
