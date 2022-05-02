using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float BetweenWaves = 4f;
    private float countDown = 3f;

    public Text waveCountdownText;

    private int waveIndex = 0; 

    void Start()
    {
        waveCountdownText.text = Mathf.Floor(countDown).ToString();
    }

    void Update()
    {
        if(countDown <= 0f)
        {
            
            StartCoroutine(SpawnWave());
            countDown = BetweenWaves;

        }
        countDown -= Time.deltaTime;

        countDown = Mathf.Clamp(countDown, 0f, Mathf.Infinity);
        waveCountdownText.text = string.Format("{0:0.0}", countDown);
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        PlayerStats.Rounds++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.3f);
        }
        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
