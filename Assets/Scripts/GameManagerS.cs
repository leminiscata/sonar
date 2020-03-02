using UnityEngine;
using UnityEngine.UI;

public class GameManagerS : MonoBehaviour
{
    // inspector
    public GameObject enemyPrefab;
    public AudioClip sfxSonar;
    public AudioClip sfxShieldHit;
    public AudioClip sfxBaseHit;
    public AudioSource aSource;
    public Text textKillCount;
    public Transform radarCenter;

    // config
    public Config config;

    // aux
    float enemySpawnCounter = 0;
    int killCount = 0;
    float enemySpawnInterval;
    public float enemySpeed;

    private void Start()
    {
        enemySpawnInterval = config.enemyInitialSpawnInterval;
        enemySpeed = config.enemyInitialSpeed;
    }

    void Update()
    {
        enemySpawnCounter -= Time.deltaTime;
        if (enemySpawnCounter <= 0)
        {
            enemySpawnCounter = enemySpawnInterval;
            Instantiate(enemyPrefab);
        }

        enemySpeed += Time.deltaTime * config.enemyAcceleration / 100;
        enemySpawnInterval -= config.enemySpawnAceleration * Time.deltaTime / 100;
    }

    public void EnemyDied()
    {
        killCount++;
        textKillCount.text = killCount.ToString();
    }
}
