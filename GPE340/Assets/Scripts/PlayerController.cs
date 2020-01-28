<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       player.Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Pawn pawn;

    [SerializeField]
    private Camera main;


    private void Update()
    {
        //pass the inputs to the pawn to move
        pawn.HandleMovement(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        
        //for running
        if(Input.GetKey(KeyCode.LeftShift))
        {
            //Debug.Log("Running Now");
            pawn.anim.SetBool("isWalking", false);
        }
        else
        {
            //Debug.Log("Walking Now");
            pawn.anim.SetBool("isWalking", true);
        }

        //for crouching
        if(Input.GetKey(KeyCode.LeftControl))
        {
            //Debug.Log("Crouching Now");
            pawn.anim.SetBool("isCrouching", true);
        }
        else
        {
            //Debug.Log("Standing Now");
            pawn.anim.SetBool("isCrouching", false);
        }
    }


}
>>>>>>> master
