using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EternalCoin : MonoBehaviour
{
    public float rotateSpeed;
    public float eternalScore;
    //point amount for collecting coins
    public float EternalPoints = 1;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //the rotation of the coins
       transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); 
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            //adds coin points to player score upon collection
            GameManager.instance.eternalCoinsCollected += EternalPoints;
            Destroy(gameObject);
        }
    }
}
