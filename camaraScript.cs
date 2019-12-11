using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraScript : MonoBehaviour
{
    public static float offsetX;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Movimiento.instance != null)
        {
            if (Movimiento.instance.isAlive)
            {
                MoveTheCamera();
            }
        }
    }

    void MoveTheCamera()
    {
        Vector3 temp = transform.position;
        temp.x = Movimiento.instance.GetPositionX() + offsetX;
        transform.position = temp;
    }
}
