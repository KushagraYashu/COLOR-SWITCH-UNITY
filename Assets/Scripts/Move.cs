using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
   
    public Transform left_x;
    public Transform right_x;

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.Lerp(left_x.position, right_x.position, Mathf.PingPong(Time.time * speed, 1.0f));;
    }
}
