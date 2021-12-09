using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    public Transform Player;
    void Update()
    {

        gameObject.transform.position = Player.transform.position + offset;

    }
}
