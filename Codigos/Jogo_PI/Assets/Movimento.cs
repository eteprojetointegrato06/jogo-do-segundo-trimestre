using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rig;
    public bool isJumping;
    public bool doubleJump;
    public float JumpForce;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
         rig = GetComponent<Rigidbody2D>();

         anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
        float inputAxis = Input.GetAxis("Horizontal");

        //Correr direita
        if(Input.GetAxis("Horizontal")>0f)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        //Correr esquerda
        if(Input.GetAxis("Horizontal")<0f)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector2(0f, 180f);
        }
        //Parado
        if(Input.GetAxis("Horizontal")==0f)
        {
            anim.SetBool("run", false);
        }
    }


    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            anim.SetBool("jump", true);
            //doubleJump = false;
        }
        else
        {
            anim.SetBool("jump", false);
            anim.SetBool("fall", true);
        }
    }

    void 

        //else
        //{
            //if (doubleJump)
            //{
                //rig.AddForce(new Vector2(0f, JumpForce * 2f), ForceMode2D.Impulse);
               // doubleJump = true;
            //}
        //}
    }
}
