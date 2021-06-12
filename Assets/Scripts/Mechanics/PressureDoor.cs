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

    [SerializeField]
    float moveValue = 0.1f;

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
        
        this.transform.position = Vector2.Lerp(curPosition, position, moveValue * Time.deltaTime);

    }
}
