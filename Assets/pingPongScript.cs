using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingPongScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 3), transform.position.z);
    }
}
