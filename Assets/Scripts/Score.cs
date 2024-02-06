using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int scoreAmount = 1;
    private ScoreManager _scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (_scoreManager == null)
        {
            return;
        }

        if (!col.gameObject.CompareTag("Player"))
        {
            return;
        }
        _scoreManager.AddScore(scoreAmount);
        //Debug.Log("Score added by " + scoreAmount);
    }
}
