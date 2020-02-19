using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers

public class Strings : MonoBehaviour
{

    public float time = 1.0f;
    public Text startText; 

    Color lerpedColor = new Color(250/255f, 220/255f, 47/255f);

    void Update()
    {
        time += Time.deltaTime;
        startText.color= lerpedColor;
        startText.text = "" + (time).ToString("0");


        if (time/2 == 0)
        {
        lerpedColor = Color.Lerp(new Color(0.5f, 0.5f, 0.5f), Color.red, Mathf.PingPong(Time.time, 10000));

        }
    }
}