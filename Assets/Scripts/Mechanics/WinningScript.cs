using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningScript : MonoBehaviour
{
    [SerializeField]
    int numCharacters;


//    int triggered=0;

    GameObject objective;

    private void Start()
    {
        objective = GameObject.FindGameObjectWithTag("Objective");
        objective.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //triggered++;
        if(collision.CompareTag("Player"))
        {

            if(collision.gameObject.GetComponent<JoiningMechanics>().joined)
            {
                objective.SetActive(false);
                SceneHandler.levelWon();
            }
            else
            {
                objective.SetActive(true);
            }
            //if (0 < triggered && triggered < numCharacters)
            //{
            //    objective.SetActive(true);
            //}
            //else if (triggered == numCharacters)
            //{
            //    objective.SetActive(false);
            //    SceneHandler.levelWon();
            //}
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //triggered--;
        objective.SetActive(false);
    }
}
