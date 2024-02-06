using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private movement _movement;
    private ScoreHandler _scoreHandler;
    public TMP_Text _startText;
    public TMP_Text _quitText;
    public TMP_Text _titleText;

    public void Start()
    {
        _movement = FindAnyObjectByType<movement>();
        _scoreHandler = FindAnyObjectByType<ScoreHandler>();
    }
    public void Update()
    {
        if (_movement == null)
        {
            Debug.Log("Null movement script reference");
            return;
        }
        
        if (_movement.gameStarted == false)    
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _movement.gameStarted = true;
                GameObject.Destroy(_startText.gameObject);
                GameObject.Destroy(_quitText.gameObject);
                GameObject.Destroy(_titleText.gameObject);
                _scoreHandler.ScoreUI.text = "Score : 0";
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
        
                       
    }
    

}
