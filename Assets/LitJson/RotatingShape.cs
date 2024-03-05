using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingShape : MonoBehaviour
{
    public Vector3 rotationSpeed; // Speed of rotation in degrees per second

    // Update is called once per frame
    void Update()
    {
        // Rotate the GameObject continuously
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
