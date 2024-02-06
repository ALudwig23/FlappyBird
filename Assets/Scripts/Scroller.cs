using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float speed = 2f;
    private SpriteRenderer _spriteRenderer;
    
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed , 0);

        _spriteRenderer.material.mainTextureOffset = offset;
    }
}
