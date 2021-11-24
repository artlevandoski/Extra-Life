using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
   public TextMeshProUGUI scoreText;

   void Update()
   {
       //tracking for the player coin score
       scoreText.text = "Coins: " + PlayerScore.score;
   }
}
