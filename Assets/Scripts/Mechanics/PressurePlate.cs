using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PressurePlate : MonoBehaviour
{
    [SerializeField]
    PressureDoor door;

    void OnTriggerEnter2D(Collider2D other)
    {
        door.toggleState();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        door.toggleState();
    }
}
