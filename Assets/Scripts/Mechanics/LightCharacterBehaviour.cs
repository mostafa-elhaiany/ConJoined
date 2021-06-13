using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LightCharacterBehaviour : MonoBehaviour
{
   
    GameObject player;
    private Rigidbody2D rb;

    [SerializeField]
    float speed;

    void Start()
    {
    
        player =  GameObject.FindGameObjectsWithTag("Player")[0];
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(player.GetComponent<JoiningMechanics>().joined  &&  Vector2.Distance(transform.position, player.transform.position)>1.0f ){
        
         float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
        }
    }
}
