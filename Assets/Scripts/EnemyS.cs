using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers


public class EnemyS : MonoBehaviour

{
    SpriteRenderer srender;
    GameManagerS gm;




    void Start()
    {
        gm = FindObjectOfType<GameManagerS>();
        srender = GetComponent<SpriteRenderer>();
        SetOpacity(0);
        var angle = Random.Range(0, 360);
        transform.position = gm.radarCenter.position + new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle), Mathf.Cos(Mathf.Deg2Rad * angle))* 3.2f;
    }

    void Update()
    {
        if (!gm.totalVisionMode && srender.color.a > 0)
            SetOpacity(srender.color.a - Time.deltaTime);
        transform.position += (gm.radarCenter.position - transform.position).normalized * gm.enemySpeed * Time.deltaTime / 10;
    }

    void PlaySFX(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, -10), 1);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Line")
        {
            PlaySFX(gm.sfxSonar);
            SetOpacity(1);
        }
        if (col.gameObject.name == "Shield")
        {
            PlaySFX(gm.sfxShieldHit);
            Destroy(gameObject);
			gm.EnemyDied();
        }
        if (col.gameObject.name == "Base")
        {
            if (!gm.noFailMode)
                SceneManager.LoadScene("End");
            Destroy(gameObject);
        }
    }

    void SetOpacity(float opacity)
    {
        if (gm.totalVisionMode)
            opacity = 1;
        Color c = srender.color;
        c.a = opacity;
        srender.color = c;
    }
}
