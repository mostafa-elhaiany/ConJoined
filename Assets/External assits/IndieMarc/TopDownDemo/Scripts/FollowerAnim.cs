using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndieMarc.TopDown
{
    
    [RequireComponent(typeof(Animator))]
    public class FollowerAnim : MonoBehaviour
    {
        private GameObject mc;
        private CharacterHoldItem character_item;
        private PlayerCharacter character;
        private Animator animator;

        void Awake()
        {
            mc = GameObject.FindGameObjectsWithTag("Player")[0];
            character = mc.GetComponent<PlayerCharacter>();
            character_item = GetComponent<CharacterHoldItem>();
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            if (mc.GetComponent<JoiningMechanism>().joined) { 
            //Anims
            animator.SetFloat("Speed", character.GetMove().magnitude);
            animator.SetInteger("Side", character.GetSideAnim());
            if (character_item != null)
                animator.SetBool("Hold", character_item.GetHeldItem() != null);
        }
}
    }

}