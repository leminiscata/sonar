using UnityEngine;

public class LineS : MonoBehaviour
{
    public float rotateSpeed;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -rotateSpeed));
    }
}
