using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvPlayer : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public Rigidbody rig;

    //this is done do that all movement code is called in one function
    void Update()
    {
        Move();

        if(Input.GetKeyDown(KeyCode.Space))
            Jump();

    }
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //maintains relative direction player is facing, multiplied by movespeed, fall based on gravity
        Vector3 dir = transform.right * x + transform.forward * z;
        dir *=moveSpeed;
        dir.y = rig.velocity.y;

        rig.velocity = dir;
    }

      void Jump ()
    {
        if(CanJump())
        {
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    //Set up a Raycast to determine if the player is on the ground, raycast sends out an invisible line about 10 meters
    bool CanJump ()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 0.1f))
        {
            return hit.collider != null;
        }

        return false;
    }
}
