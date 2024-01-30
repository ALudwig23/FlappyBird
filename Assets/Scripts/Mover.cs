using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed = 7f;
    private void FixedUpdate()
    {
        Vector2 targetMovePos = transform.position;
        targetMovePos.x -= moveSpeed * Time.deltaTime;     

        transform.position = targetMovePos;

        if (targetMovePos.x <= -14)
        {
            Destroy(gameObject);
        }
    }
}
