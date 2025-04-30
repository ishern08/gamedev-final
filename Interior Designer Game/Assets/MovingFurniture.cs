using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFurniture : MonoBehaviour
{
    public new GameObject gameObject;
    public float movingAngle = -90.0f;

    public float movingAmount = 5.0f;


    public void MovingFurnX()
    {
        gameObject.transform.Rotate(movingAngle, 0.0f, 0.0f, Space.Self);
    }

    public void MovingFurnY()
    {
        gameObject.transform.Rotate(0.0f, movingAngle, 0.0f, Space.Self);
    }

    public void MovingFurnZ()
    {
        gameObject.transform.Rotate(0.0f, 0.0f, movingAngle, Space.Self);
    }

    public void MovingFurnPosX()
    {
       Vector3 pos = gameObject.transform.position;
       pos.x += movingAmount;
       gameObject.transform.position = pos;

    }

    public void MovingFurnPosZ()
    {
       Vector3 pos = gameObject.transform.position;
       pos.z += movingAmount;
       gameObject.transform.position = pos;

    }
}
