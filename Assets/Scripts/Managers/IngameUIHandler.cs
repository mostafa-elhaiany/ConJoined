using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IngameUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    
    GameObject inGameCanvas;
    Text joinOptionText; 

    

    void Start()
    {
        player =  GameObject.FindGameObjectsWithTag("Player")[0];
        joinOptionText = GameObject.Find("JoinOptionText").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(player.GetComponent<JoiningMechanics>().inProximity && !player.GetComponent<JoiningMechanics>().joined){
            //option to join
            Color zm = joinOptionText.color;  //  makes a new color zm
            zm.a = 1.0f;
            joinOptionText.color  = zm;
        }
        if(!player.GetComponent<JoiningMechanics>().inProximity || player.GetComponent<JoiningMechanics>().joined){
            //no option
            //joinOptionText.color.a  = 0.0f;
            //joinOptionText.color  = Color.black;
            Color zm = joinOptionText.color;  //  makes a new color zm
            zm.a = 0.0f;
            joinOptionText.color  = zm;
        }
        
    }
}
