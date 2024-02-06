using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalVelocityRotator : MonoBehaviour
{
    public float RotateDown = -20f;
    public float RotateUp = 60f;

    private movement _player;

    private float _currentY;
    private float _lastY;

    public float velocity;

    void Start()
    {
        _player = transform.parent.GetComponent<movement>();
        _currentY = _lastY = transform.parent.position.y;
    }


    private void FixedUpdate()
    {
        if(_player == null)
        {
            return;
        }
            

        _currentY = _player.transform.position.y;
        velocity = _currentY - _lastY;

        velocity *= 10f;
        velocity = Mathf.Clamp(velocity, -1 , 1);
        velocity = Unity.Mathematics.math.remap(-1, 1, 0, 1, velocity);

        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 0, RotateDown), Quaternion.Euler(0, 0, RotateUp), velocity);

        _lastY = _player.transform.position.y;
    }
}
