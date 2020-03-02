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
    public bool noFailMode = false;
    public bool totalVisionMode = false;
    public float shieldRotationSpeed = 1;
    public float enemySpawnInterval = 3;
    public float spawnAceleration = 0;
    public float enemySpeed = 1;
    public float enemyAcceleration = 0;

    // aux
    float enemySpawnCounter = 0;
    int killCount = 0;

    void Update()
    {
        enemySpawnCounter -= Time.deltaTime;
        if (enemySpawnCounter <= 0)
        {
            enemySpawnCounter = enemySpawnInterval;
            Instantiate(enemyPrefab);
        }

        enemySpeed += Time.deltaTime * enemyAcceleration / 100;
        enemySpawnInterval -= spawnAceleration * Time.deltaTime / 100;
    }
	
	public void EnemyDied()
	{
		killCount++;
		textKillCount.text = killCount.ToString();
	}
}
