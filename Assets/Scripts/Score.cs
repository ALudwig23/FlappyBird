using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int scoreAmount = 10;
    private ScoreManager _scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (_scoreManager == null)
        {
            return;
        }
        Debug.Log("Score added by " + scoreAmount);
    }
}
