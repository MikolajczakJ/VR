using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportZone : MonoBehaviour
{
    public Vector3 teleportPosition = new Vector3(0, 0, 0);

    public string playerLayerName = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer(playerLayerName))
        {
            other.transform.position = teleportPosition;

            Debug.Log($"Player teleported to {teleportPosition}");
        }
    }
}
