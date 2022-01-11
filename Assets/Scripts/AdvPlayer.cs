using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdvPlayer : MonoBehaviour

{

    public float moveSpeed;
    public float jumpForce;

    public float minMoveDistance;
    public float distToGround = 1f;
    public Rigidbody rig;
    public Animator anim;
    private bool isGrounded;

    public bool jump;

    public Text deBug;
    

    //this is done do that all movement code is called in one function
    void Update()
    {
        Move();

        UpdateAnimator();
        
    }
    
    private void FixedUpdate()
    {
        if(jump)
        {
            rig.velocity += (Vector3.up * jumpForce);
            jump = false;
        }
        
        GroundCheck();
    }
    
    void Move()
    {
       float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded ==true || (Input.GetKeyDown(KeyCode.Joystick1Button0) && isGrounded ==true)) jump = true;

        //maintains relative direction player is facing, multiplied by movespeed, fall based on gravity
        Vector3 dir = transform.right * x + transform.forward * z;
        dir *=moveSpeed;
        dir.y = rig.velocity.y;

        rig.velocity = dir;

    }

    void UpdateAnimator ()
    {
        anim.SetBool("MovingForwards", false);
        anim.SetBool("MovingBackwards", false);
        anim.SetBool("MovingLeft", false);
        anim.SetBool("MovingRight", false);

        Vector3 localVel = transform.InverseTransformDirection(rig.velocity);

        if(localVel.z > 0.1f)
            anim.SetBool("MovingForwards", true);
        else if (localVel.z < -0.1f)
            anim.SetBool("MovingBackwards", true);
        else if(localVel.x < -0.1f)
            anim.SetBool("MovingLeft", true);
        else if (localVel.x > 0.1f)
            anim.SetBool("MovingRight", true);
    }

 
    void GroundCheck()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit, distToGround + .1f))
        {
            isGrounded = true;
            deBug.text = "Grounded";
        }
        else
        {
            isGrounded = false;
            deBug.text = "Not Grounded";
        }

         if(transform.position.y < -10) //ends the game if player falls too far
        {
            GameOver();
        }
        
    }

     public void GameOver()
    {
        SceneManager.LoadScene(2);
    }


}
