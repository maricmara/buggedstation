using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rig;

    private Animator anim;
    
    void Start()
    {
      rig = GetComponent<Rigidbody2D>();  
      anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
    }
/*
        if(Input.GetAxis("Horizontal") > 0f)
        {
        anim.SetBool("walk", true);
        transform.eulerAngles = new Vector3(0f,0f,0f);
        }

         if(Input.GetAxis("Horizontal") < 0f)
        {
        anim.SetBool("walk", true);
        transform.eulerAngles = new Vector3(0f,180f,0f);
        }

         if(Input.GetAxis("Horizontal") == 0f)
        {
        anim.SetBool("walk", false);
        }
    }
*/
}

