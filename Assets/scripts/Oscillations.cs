using System;
using UnityEngine;

public class Oscillations : MonoBehaviour
{
 
    Vector3 Position;
    void Start()
    {
        Position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Position.y = Mathf.Sin(Time.time + transform.position.z);

        transform.position = Position;
        
    }
}
