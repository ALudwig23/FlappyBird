using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float upwardsForce = 200f;
    private Rigidbody2D _rigidbody2d;
    private Collider2D _collider2d;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _collider2d = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidbody2d == null )
        {
            Debug.Log("RigidBody2D missing.");
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2d.velocity = Vector2.zero;
            _rigidbody2d.AddForce(Vector2.up * upwardsForce); //0,1
        }
        //Debug.Log("Flaps upwards");
    }
}
