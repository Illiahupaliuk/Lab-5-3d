using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anima : MonoBehaviour
{

    bool stop = true;


    private Animator anim;
    private CharacterController characterController;
    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

      

        if (Input.GetButton("Horizontal")|| Input.GetButton("Vertical"))
        { State = States.go;
            stop = true; }
        else if( stop == true) { State = States.idle; }

        if (Input.GetButtonDown("Fire1"))
        { State = States.prycil;
        stop = false;

        }
    

        if (Input.GetButtonDown("Jump"))
        { State = States.jump; 
        stop = false;   
        }
      


    }


    public enum States
    {
        idle,
        go,
       jump,
       prycil
    }
}
