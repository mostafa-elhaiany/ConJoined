using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoiningMechanics : MonoBehaviour
{
    public bool inProximity;
     public Material MyMaterial;
    GameObject lightCharachter;

    AudioSource audioSrc;

    LineRenderer myLine;
    GameObject joiningText;
    public bool joined; 
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = gameObject.GetComponent<AudioSource>();
        lightCharachter = GameObject.FindGameObjectWithTag("LightCharacter");
        joiningText = GameObject.FindGameObjectWithTag("ingameUI");
    }


     LineRenderer DrawLine(Vector3 start, Vector3 end, Color color)
             {
                 GameObject myLine = new GameObject();
                 myLine.transform.position = start;
                 myLine.AddComponent<LineRenderer>();
                 LineRenderer lr = myLine.GetComponent<LineRenderer>();
                 lr.material = MyMaterial;
                 lr.SetColors(color, color);
                 lr.SetWidth(0.5f, 0.5f);
                 lr.SetPosition(0, start);
                 lr.SetPosition(1, end);
                 return lr;
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
        if (inProximity && Input.GetKeyDown(KeyCode.Space)){
            joined = !joined;
            if(joined)
            {
                audioSrc.Play();
                myLine = DrawLine(this.gameObject.transform.position,lightCharachter.transform.position,Color.yellow);
            }
        }
        else if(!inProximity && joined && Input.GetKeyDown(KeyCode.Space))
        {
            joined = false;
            
            GameObject.Destroy(myLine);
        }
        joiningText.SetActive(inProximity && !joined);
         if(joined)
            {
                 myLine.SetPosition(0, this.gameObject.transform.position);
                 myLine.SetPosition(1, lightCharachter.transform.position);}
    }
   
}
