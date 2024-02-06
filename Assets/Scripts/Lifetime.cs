using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public float duration = 2f;
    private float _timer;
    
    void Start()
    {
        _timer = duration;
    }

    
    void Update()
    {
        if (_timer > 0 )
        {
            _timer -= Time.deltaTime;
            return;
        }
        Destroy(gameObject);
    }
}
