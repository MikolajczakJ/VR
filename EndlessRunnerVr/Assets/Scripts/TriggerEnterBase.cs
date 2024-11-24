using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterBase : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
     {
          Interact(other);
     }
    protected virtual void Interact(Collider other)
    {
        Debug.Log(other.gameObject);
        gameObject.SetActive(false);
    }
}

