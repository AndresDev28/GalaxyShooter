using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyShipPrefab;
    [SerializeField]
    private GameObject[] _powerups;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(EnemySpawnRutine());
       StartCoroutine(PowerupSpawnRutine()); 
    }

    IEnumerator EnemySpawnRutine()
    {
        while (true)
        {
            Instantiate(_enemyShipPrefab, new Vector3(Random.Range(-8f, 8f), 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
        
    }

    IEnumerator PowerupSpawnRutine()
    {
        while (true)
        {
            int randomPowerup = Random.Range(0, 3);
            Instantiate(_powerups[randomPowerup], new Vector3(Random.Range(-8f, 8f), 7, 0), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
            
}
