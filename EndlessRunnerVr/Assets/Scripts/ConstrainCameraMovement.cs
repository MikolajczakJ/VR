using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstrainCameraMovement : MonoBehaviour
{
    [SerializeField] public float minX;
    [SerializeField] public float maxX;
    void Update()
    {
        // Get the current position of the camera
        Vector3 position = transform.position;

        // Constrain the position on the X-axis
        position.x = Mathf.Clamp(position.x, minX, maxX);

        // Apply the constrained position back to the camera
        transform.position = position;
    }
}
