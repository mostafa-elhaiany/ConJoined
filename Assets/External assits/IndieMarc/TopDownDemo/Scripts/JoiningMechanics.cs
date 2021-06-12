using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoiningMechanics : MonoBehaviour
{
    public bool inProximity;
        GameObject lightCharachter;

        bool isMoving;

        public bool joined; 
    // Start is called before the first frame update
    void Start()
    {
        lightCharachter = GameObject.FindGameObjectsWithTag("LightCharacter")[0];
        
    }

    // Update is called once per frame
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

            
        
    }
}
