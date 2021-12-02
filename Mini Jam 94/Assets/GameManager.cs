using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    int score = 0;

    private void Start() {
     
    }
    public void UpdateScore(int ScoreToAdd)
    {
        score += ScoreToAdd; 
        Debug.Log(score); 
    } 

    
}
