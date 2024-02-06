using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private ToEndScene _toEndScene;

    public void Start()
    {
        _toEndScene = FindAnyObjectByType<ToEndScene>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject.Destroy(col.gameObject);
        //Debug.Log("Player deleted");
        _toEndScene.EndScene();
    }
}
