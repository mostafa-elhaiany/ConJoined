using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Event
{
    public GameObject[] activate;
    public GameObject[] deactivate;

    public bool timerBased;
    public float timeToFinish;



}