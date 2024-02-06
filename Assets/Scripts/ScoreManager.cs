using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;
    
    public void AddScore(int score)
    {
        Score += score;
        PlayerPrefs.SetInt("Score", Score);
        PlayerPrefs.Save();
        //Debug.Log("Score value changed to " + Score);
    }
}
