using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb; 
    
    private void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

     private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 8f;
            rb.velocity = Vector2.up* jumpVelocity;
        }
    }
   void OnCollisionEnter2D(Collision2D collision) 
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 
}

