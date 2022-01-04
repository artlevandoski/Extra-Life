using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EternalCoin : MonoBehaviour
{
    public float rotateSpeed;
    
        // Update is called once per frame
    void Update()
    {
        //the rotation of the coins
       transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

}
