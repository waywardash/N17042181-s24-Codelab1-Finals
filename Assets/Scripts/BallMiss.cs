using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMiss : MonoBehaviour
{
    // Delta represents the maximum displacement from the starting position
    public float delta = 1.5f;
    
    // Speed represents how fast the ball mov seside to side
    public float speed = 2.0f;
    
    // The starting position of the ball
    private Vector3 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        // Store the initial position of the ball
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the horizontal displacement using a sine wave based on time
        // This creates a back-and-forth motion
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        
        // Update the position of the ball
        transform.position = v;
    }
}