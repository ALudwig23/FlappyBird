using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private ScoreManager _scoreManager;
    public TMP_Text ScoreUI;
    
    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
        ScoreUI = GetComponent<TMP_Text>();
    }
    void Update()
    {
        if (ScoreUI == null)
        {
            Debug.Log("ScoreUI missing");
            return;
        }

        if (_scoreManager == null)
        {
            Debug.Log("ScoreManger missing");
            return;
        }
            
                
        ScoreUI.text = "Score: " + _scoreManager.Score.ToString();
        //Debug.Log("Score printed");
    }
}
