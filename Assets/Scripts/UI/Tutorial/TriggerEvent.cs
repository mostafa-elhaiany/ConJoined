using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField]
    HandleTutorial tutScript;

    bool triggered = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !triggered)
        {
            triggered = true;
            tutScript.triggerTaskDone();
        }
    }
}
