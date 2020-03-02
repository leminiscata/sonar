using UnityEngine;

public class ShieldS : MonoBehaviour
{
    GameManagerS gm;
    public Transform shieldBase;
    // int v = 0, h = 0;
    bool isHoldingCW = false;
    bool isHoldingACW = false;

    void Start()
    {
        gm = FindObjectOfType<GameManagerS>();
    }

    void Update()
    {
        if (isHoldingCW)
            shieldBase.Rotate(0, 0, -1 * gm.shieldRotationSpeed);
        else if (isHoldingACW)
            shieldBase.Rotate(0, 0, 1 * gm.shieldRotationSpeed);

        // implementação antiga da movimentação do Shield
        //if (Input.GetKey(KeyCode.UpArrow))
        //    v = 1;
        //else if (Input.GetKey(KeyCode.DownArrow))
        //    v = -1;
        //else
        //    v = 0;

        //if (Input.GetKey(KeyCode.RightArrow))
        //    h = 1;
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //    h = -1;
        //else
        //    h = 0;

        //if (v != 0 || h != 0)
        //    shieldBase.rotation = Quaternion.AngleAxis(Mathf.Atan2(v, h) * Mathf.Rad2Deg, Vector3.forward);
    }

    public void OnPointerDownCW()
    {
        isHoldingCW = true;
    }

    public void OnPointerUpCW()
    {
        isHoldingCW = false;
    }

    public void OnPointerDownACW()
    {
        isHoldingACW = true;
    }

    public void OnPointerUpACW()
    {
        isHoldingACW = false;
    }
}
