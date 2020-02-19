using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldS : MonoBehaviour
{
    public Transform shieldBase;
    int v = 0, h = 0;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            v = 1;
        else if (Input.GetKey(KeyCode.DownArrow))
            v = -1;
        else
            v = 0;

        if (Input.GetKey(KeyCode.RightArrow))
            h = 1;
        else if (Input.GetKey(KeyCode.LeftArrow))
            h = -1;
        else
            h = 0;

        if (v != 0 || h != 0)
            shieldBase.rotation = Quaternion.AngleAxis(Mathf.Atan2(v, h) * Mathf.Rad2Deg, Vector3.forward);
    }
}
