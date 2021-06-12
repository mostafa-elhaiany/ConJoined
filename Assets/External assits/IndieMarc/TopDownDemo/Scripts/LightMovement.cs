using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IndieMarc.TopDown{
public class LightMovement : MonoBehaviour
{
    GameObject player;
    int player_id =0;
    private Rigidbody2D rigid;
    private Vector2 move_input;
    public float move_accel;
    private Vector2 move;
        public float move_deccel;
        public float move_max;
        private Rigidbody2D playerRigid;
    private static Dictionary<int, LightMovement> character_list = new Dictionary<int, LightMovement>();
    // Start is called before the first frame update
    void Awake()
        {
            character_list[player_id] = this;
            rigid = GetComponent<Rigidbody2D>();
        }
    void Start()
    {
        move_accel = 10f;
        move_deccel = 20f;
         move_max = 3f;
        player =  GameObject.FindGameObjectsWithTag("Player")[0];
        playerRigid = player.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
            move_input = Vector2.zero;

            //Controls
            if (player.GetComponent<JoiningMechanics>().joined && playerRigid.velocity != Vector2.zero)
            {
                //Controls
                PlayerControls controls = PlayerControls.Get(player_id);
                move_input = controls.GetMove();
                
            }
        
    }
    void FixedUpdate()
        {
            //Movement velocity
            float desiredSpeedX = Mathf.Abs(move_input.x) > 0.1f ? move_input.x * move_max : 0f;
            float accelerationX = Mathf.Abs(move_input.x) > 0.1f ? move_accel : move_deccel;
            move.x = Mathf.MoveTowards(move.x, desiredSpeedX, accelerationX * Time.fixedDeltaTime);
            float desiredSpeedY = Mathf.Abs(move_input.y) > 0.1f ? move_input.y * move_max : 0f;
            float accelerationY = Mathf.Abs(move_input.y) > 0.1f ? move_accel : move_deccel;
            move.y = Mathf.MoveTowards(move.y, desiredSpeedY, accelerationY * Time.fixedDeltaTime);

            //Move
            rigid.velocity = move;
            
        }
    public Vector2 GetMove()
        {
            return move;
        }
}
}
