using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animator animator;

    void Start ()

    {
        animator = GetComponent<Animator>(); //calls animations for the player model
    }
    public float moveSpeed;
    public Rigidbody rig;
    public float jumpforce;

    //public int score; 
    public static float score;

    private bool isGrounded = true;

    public UI uI;

    // Update is called once per frame
    void Update()
    {
        // get the horizontal and vertical inputs
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;
        animator.SetTrigger("Walk");//triggers walk animation
        

        // set our velocity based on our inputs
        rig.velocity = new Vector3(x, rig.velocity.y, z);
        
        // create a copy of our velocity variable and 
        //set the Y axis to be 0
        Vector3 vel = rig.velocity;
        vel.y = 0;

        // if we're moving, rotate to face our moving direction
        if (vel.x != 0 || vel.z != 0)
        {
            transform.forward = vel;
        }

        if(Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.Joystick1Button0) && isGrounded ==true))
        {
            isGrounded = false;
            rig.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            animator.SetTrigger("Jump");//calls jump animation
        }

        if(transform.position.y < -10) //ends the game if player falls too far
        {
            GameOver();
        }
    }

    private void OnCollisionEnter(Collision collision)//collison with ground
    {
        if(collision.contacts[0].normal == Vector3.up)
        {
            isGrounded = true;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
