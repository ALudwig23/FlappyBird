using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Analytics;

public class EndScore : MonoBehaviour
{
    public TMP_Text score;
    public GameObject gameOverSFX;

    public void Start()
    {
        
        score = GetComponent<TMP_Text>();
        int finalScore = PlayerPrefs.GetInt("Score", 0);
        score.text = "Final Score : " + finalScore.ToString();
        GameObject.Instantiate(gameOverSFX, transform.position, transform.rotation);

    }
}
