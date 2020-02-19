using UnityEngine;
using UnityEngine.UI;

public class GameManagerS : MonoBehaviour
{
    public GameObject enemyPrefab;
    public AudioClip sfxSonar;
    public AudioClip sfxShieldHit;
    public AudioClip sfxBaseHit;
    public bool noFailMode = false;
    public bool totalVisionMode = false;
    public float enemySpawnInterval = 3;
    public float spawnAceleration = 0;
    public float enemySpeed = 1;
    public float enemyAcceleration = 0;
    float enemySpawnCounter = 0;
    public AudioSource aSource;
    public Text textKillCount; 
	int killCount = 0;
	public Transform radarCenter;

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
