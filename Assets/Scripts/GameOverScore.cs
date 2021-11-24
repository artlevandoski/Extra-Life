using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
   public static float score;
   public TextMeshProUGUI scoreText;
  
   //displays the score of the player on game over screen
   public void SetScoreText (float score)
   {
       scoreText.text = score.ToString();
   }
}

