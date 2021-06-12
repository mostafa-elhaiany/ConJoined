using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interactable : MonoBehaviour
{
    Text interactableText; 

    private Vector3 offset;
    bool triggered;
    

    Camera Cam;
    public bool interacted;

    
    // Start is called before the first frame update
    void Start()
    {

        Cam = Camera.main;

        offset = new Vector3(0f,1f,0f);

        interactableText = GameObject.FindGameObjectWithTag("InteractionText").GetComponent<Text>();
        
        
    }


void OnTriggerEnter2D(Collider2D other){


     Debug.Log("entered changed");
    if(other.gameObject.tag == "Player"){
        triggered= true;
        Vector2 pos = other.transform.position - offset;  
        // get the game object position
        Vector2 viewportPoint = Camera.main.WorldToViewportPoint(pos);  //convert game object position to VievportPoint
            RectTransform assign_text_1RT = interactableText.GetComponent<RectTransform>();
        // set MIN and MAX Anchor values(positions) to the same position (ViewportPoint)
        assign_text_1RT.anchorMin = viewportPoint;  
        assign_text_1RT.anchorMax = viewportPoint; 

        //changing alpha channel
        Color zm = interactableText.color;
            
        zm.a = 1.0f;
        interactableText.color  = zm;
    }
 }

  void OnTriggerExit2D(Collider2D other){
    if(other.gameObject.tag == "Player"){
        triggered= false;
            Color zm = interactableText.color;  //  makes a new color zm
            zm.a = 0.0f;
            interactableText.color  = zm;
            //interacted= false;
        }
        
 }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            interacted = true;
        }

        Color zm = interactableText.color;  //  makes a new color zm
            if(!interacted && triggered){
            zm.a = 1.0f;
            interactableText.color  = zm;

            }
            if(interacted ){
                
                zm.a = 0.0f;
                interactableText.color  = zm;
                
            }
            if(!triggered && interacted){
                interacted= false;

            }
        
        
    }
}
