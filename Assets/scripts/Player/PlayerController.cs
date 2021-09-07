using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 5;
    public int Sensibilite = 1;
    public int Jump = 10;
    public int Gravity = 20;

    private bool mouseControl;
    private Vector3 DirDepl = Vector3.zero;
    private CharacterController Player;
    private Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        mouseControl = true;
        Player = GetComponent<CharacterController>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ///// déplacement 
        DirDepl.z = Input.GetAxisRaw("Vertical");
        DirDepl.x = Input.GetAxisRaw("Horizontal");
        DirDepl = transform.TransformDirection(DirDepl);
        Player.Move(DirDepl * Time.deltaTime * speed);

        /////// rotation 
        if (mouseControl == true){
            transform.Rotate(0, Input.GetAxisRaw("Mouse X") * Sensibilite, 0);
        }
        /////// saut
        if(Input.GetKeyDown(KeyCode.Space) && Player.isGrounded)
        {
            DirDepl.y = Jump;
            Anim.SetTrigger("jump");
        }
        if(!Player.isGrounded){
            DirDepl.y -= Gravity * Time.deltaTime;
        }

        ///// animation
        if(Input.GetKey(KeyCode.Z))
        {
            Anim.SetBool("Walk", true);
        }
        if(Input.GetKeyUp(KeyCode.Z))
        {
            Anim.SetBool("Walk", false);
        }
        if(Input.GetKey(KeyCode.S))
        {
            Anim.SetBool("WalkBack", true);
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            Anim.SetBool("WalkBack", false);
        }
    }

    public void setMouseControl(bool set){
        mouseControl = set;
    }
}
