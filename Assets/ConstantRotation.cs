using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle in the direction of 'motion', multiplied by Time.deltaTime to make it frame rate independent
        transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);
    }
}
