using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Spawn[] _spawn;
    private int _currentEnemyIndex;
    private int _currentSpawnIndex;
    private int _enemiesLeftToSpawn;

    
    private static EnemyManager instance;
    public static EnemyManager Instance
    {
        get { return instance; }
    }
   

    void Start()
    {
        
    }
    private void SpawnEnemy()
    {
        if (Timer.pos)
        {
            _enemiesLeftToSpawn = _spawn[0].SpawnSettings.Length;
            _currentEnemyIndex = 0;
        }
        if (!Timer.pos)
        {
            if (_enemiesLeftToSpawn > 0)
            {
                Instantiate(_spawn[_currentSpawnIndex]
                    .SpawnSettings[_currentEnemyIndex]
                    .Enemy,
                    _spawn[_currentSpawnIndex]
                    .SpawnSettings[_currentEnemyIndex]
                    .SpawnPoint.position,
                    Quaternion.identity);
                _enemiesLeftToSpawn--;
                _currentEnemyIndex++;
            }
        }
    }


    void Update()
    {
        SpawnEnemy();
    }
    public static void EnemyDead()
    {
        MoneySystem.ScoreMoney += 50;
    }

}
[System.Serializable]
public class Spawn
{
    [SerializeField] private SpawnSettings[] _spawnSettings;
    public SpawnSettings[] SpawnSettings { get => _spawnSettings; }
}
[System.Serializable]
public class SpawnSettings
{
    [SerializeField] private GameObject _enemy;
    public GameObject Enemy { get =>  _enemy; }
    [SerializeField] private Transform _spawnPoint;
    public Transform SpawnPoint { get => _spawnPoint;}
}