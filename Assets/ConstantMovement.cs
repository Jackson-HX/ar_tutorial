using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float speed = 0.3f;  // This will move the vehicle forward along the Z-axis

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle in the direction of 'motion', multiplied by Time.deltaTime to make it frame rate independent
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
}
