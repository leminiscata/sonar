using UnityEngine;

[CreateAssetMenu(fileName = "Config", menuName = "ScriptableObjects/Config", order = 1)]
public class Config : ScriptableObject
{
    public bool noFailMode = false;
    public bool totalVisionMode = false;
    public float shieldRotationSpeed = 1;
    public float enemyInitialSpeed = 1;
    public float enemyAcceleration = 0;
    public float enemyInitialSpawnInterval = 3;
    public float enemySpawnAceleration = 0;
}
