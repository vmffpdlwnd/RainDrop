using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    float direction = 0.05f;
    new SpriteRenderer renderer;
    void Start()
    {
        Application.targetFrameRate = 60;
        renderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)|Input.GetKeyDown(KeyCode.Space))
        {
            direction *= -1;
            renderer.flipX = !renderer.flipX;
        }
        if(transform.position.x > 2.6f)
        {
            direction *= -1;
            renderer.flipX = true;
        }
        if (transform.position.x < -2.6f)
        {
            direction *= -1;
            renderer.flipX = false;
        }
        transform.position += Vector3.right * direction;
    }
    
}
