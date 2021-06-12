using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PressurePlate : MonoBehaviour
{
    [SerializeField]
    List<PressureDoor> PressureDoor_list = new List<PressureDoor>();

    void OnTriggerEnter2D(Collider2D other)
    {
        foreach (PressureDoor door in PressureDoor_list)
            {
               
                door.toggleState();
            }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        foreach (PressureDoor door in PressureDoor_list)
            {
               
        door.toggleState();
            }
    }
}
