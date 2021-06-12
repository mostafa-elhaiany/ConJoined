using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningScript : MonoBehaviour
{
    [SerializeField]
    int numCharacters;


    int triggered=0;

    GameObject objective;

    private void Start()
    {
        objective = GameObject.FindGameObjectWithTag("Objective");
        objective.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered++;
        if(collision.CompareTag("Player"))
        {
            if (0 < triggered && triggered < numCharacters)
            {
                objective.SetActive(true);
            }
            else if (triggered == numCharacters)
            {
                objective.SetActive(false);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered--;
        objective.SetActive(false);
    }
}
