using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool joined;
    public bool inProximity;
    public GameObject lightCharachter;

    

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
       Vector2 position = transform.position;
       position.x = position.x + 3.2f * horizontal * Time.deltaTime;
       position.y = position.y + 3.2f * vertical * Time.deltaTime;
       transform.position = position;

       if(Vector2.Distance(this.gameObject.transform.position, lightCharachter.transform.position)<1f){
           inProximity=true;
       }

       if(inProximity && Input.GetKeyDown(KeyCode.Space)){
           joined = true;
       }

        
    }
}
