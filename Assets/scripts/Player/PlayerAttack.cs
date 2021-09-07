using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private CharacterController Player;
    private Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            Anim.SetTrigger("SwordAttack");
        }
    }
}
