using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float upwardsForce = 300f;
    public bool gameStarted = false;
    public GameObject SFX;
    private Rigidbody2D _rigidbody2d;
    private Collider2D _collider2d;
    

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _collider2d = GetComponent<Collider2D>();
    }

    private void FixedUpdate()
    {
        if (gameStarted == false)
        {
            if (_rigidbody2d.position.y < 0)
            {
                _rigidbody2d.velocity = Vector2.zero;
                _rigidbody2d.AddForce(Vector2.up * upwardsForce);
            }
        }
        
    }

    
    void Update()
    {
        if (gameStarted == true)
        {
            if (_rigidbody2d == null)
            {
                Debug.Log("RigidBody2D missing.");
                return;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody2d.velocity = Vector2.zero;
                _rigidbody2d.AddForce(Vector2.up * upwardsForce);
                GameObject.Instantiate(SFX, transform.position, transform.rotation);
            }
            //Debug.Log("Flaps upwards");
        }

    }
}
