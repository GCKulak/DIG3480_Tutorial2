using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    // Transforms to act as start and end markers for the journey.
    public Transform startMarker;
    public Transform endMarker;

    // Movement speed in units/sec.
    public float speed = 1.0F;

  

    void Start()
    {
      
    }

    // Follows the target position like with a spring
    void Update()
    {
        // Distance moved = time * speed.
       
        // Set our position as a fraction of the distance between the markers and pingpong the movement.
        transform.position = Vector2.Lerp(startMarker.position, endMarker.position, Mathf.PingPong(Time.time * speed, 1));
    }
}