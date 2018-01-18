using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacleScript : MonoBehaviour
{
    float min;
    float max;
    
    //position of the moving obstacle
    void Start()
    {
        min = transform.position.y - 2f;
        max = transform.position.y + 2f;
    }
    
    //obstacle movement speed
    void Update()
    {
        this.transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 3, max - min) + min, transform.position.z);
    }
}