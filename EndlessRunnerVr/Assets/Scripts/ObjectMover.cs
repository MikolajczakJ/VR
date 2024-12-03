using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] Vector3 speedVector;
    [SerializeField] bool moveHorizontally;
    [SerializeField] private float horizontalRange = 5f;
    [SerializeField] private float horizontalSpeed = 2f;

    private bool movingRight = true;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(speedVector * Time.deltaTime);
        if (moveHorizontally)
        {
            HorizontalMovement();
        }
    }

    private void HorizontalMovement()
    {
        float currentZ = transform.position.z;
        float leftBoundary = startPosition.z - horizontalRange;
        float rightBoundary = startPosition.z + horizontalRange;

        if (currentZ <= leftBoundary)
        {
            movingRight = true;
        }
        else if (currentZ >= rightBoundary)
        {
            movingRight = false;
        }

        float horizontalDirection = movingRight ? 1 : -1;
        transform.Translate(Vector3.forward * horizontalDirection * horizontalSpeed * Time.deltaTime);
    }
}
