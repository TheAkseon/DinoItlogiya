using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Obstacle[] _obstacles;
    [SerializeField] private float _timeBetweenSpawn;
    [SerializeField] private Transform _spawnPoint;

    private float _timeAfterSpawn;

    private void Update()
    {
        _timeAfterSpawn += Time.deltaTime;

        if(_timeAfterSpawn >= _timeBetweenSpawn)
        {
            Instantiate(_obstacles[Random.Range(0, _obstacles.Length)], _spawnPoint.position, Quaternion.identity);
            _timeAfterSpawn = 0;
        }
    }
}
