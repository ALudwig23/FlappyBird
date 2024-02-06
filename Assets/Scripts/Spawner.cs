using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Obstacles;
    private movement _movement;
    public float SpawnInterval = 1f;
    private float _timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _timer = SpawnInterval;
        _movement = FindAnyObjectByType<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_movement.gameStarted == true)
        {
            if (_timer > 0f)
            {
                _timer -= Time.deltaTime;
                return;
            }

            _timer = SpawnInterval;
            int randomX = Random.Range(0, Obstacles.Length);
            float randomY = Random.Range(-3.5f, 3.5f);

            Vector2 spawnPos = new Vector2(transform.position.x, randomY);

            GameObject.Instantiate(Obstacles[randomX], spawnPos, transform.rotation);
        }
        
    }
}
