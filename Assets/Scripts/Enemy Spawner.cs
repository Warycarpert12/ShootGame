using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemeAI enemyPrefab;
    public PlayerController player;
    public List<Transform> patrolPoints;

    public int enemiesMaxCount = 5;
    public float spawnDelay = 5;

    private List<Transform> _spawnerPoints;
    private List<EnemeAI> _enemeies;

    private float _timeLastSpawned;

    private void Start()
    {
        _spawnerPoints = new List<Transform>(transform.GetComponentsInChildren<Transform>());
        _enemeies = new List<EnemeAI>();
    }

    private void Update()
    {
        if (enemiesMaxCount <= _enemeies.Count) return;
        if (Time.time - _timeLastSpawned < spawnDelay) return;
        


            CreateEnemy();
        
    }

    private void CreateEnemy()
    {
       var enemy = Instantiate(enemyPrefab);
        enemy.transform.position = _spawnerPoints[Random.Range(0, _spawnerPoints.Count)].position;
        enemy.player = player;
        enemy.patrolPoints = patrolPoints;
        _enemeies.Add(enemy);
        _timeLastSpawned = Time.time;


    }
    
}
