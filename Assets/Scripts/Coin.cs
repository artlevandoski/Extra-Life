using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed;
    public float score;
    //point amount for collecting coins
    public float pointsPerCoin = 1;

    public AudioClip coin;

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
            PlayerScore.score += pointsPerCoin;
            GameManager.instance.coinsCollected += pointsPerCoin;
            AudioSource.PlayClipAtPoint(coin, transform.position);
            Destroy(gameObject);
        }
    }
}
