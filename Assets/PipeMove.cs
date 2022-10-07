using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 0.6f;
      
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
