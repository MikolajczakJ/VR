using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] Vector3 speedVector;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedVector * Time.deltaTime);
    }
}
