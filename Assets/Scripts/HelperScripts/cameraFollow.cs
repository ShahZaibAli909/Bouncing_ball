using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed;
    public Vector3 offset;
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        //Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition,smoothSpeed);
        transform.position = desiredPosition;
        //transform.LookAt(target);
    }
}
