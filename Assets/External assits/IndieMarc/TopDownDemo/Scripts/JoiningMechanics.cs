﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoiningMechanics : MonoBehaviour
{
    public bool inProximity;
    public GameObject lightCharachter;

    bool isMoving;

    public bool joined;

    GameObject text;

    void Start()
    {
        text = GameObject.FindGameObjectWithTag("ingameUI");
    }
    void Update()
    {
        if(Vector2.Distance(this.gameObject.transform.position, lightCharachter.transform.position)<2f){
                inProximity=true;
        }
        else{
            inProximity=false;
        }
        if(inProximity && Input.GetKeyDown(KeyCode.Space)){
            joined = !joined;
        }

        text.SetActive(inProximity && !joined);
    }
}
