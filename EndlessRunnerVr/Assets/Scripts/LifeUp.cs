using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUp : TriggerEnterBase
{
    [SerializeField] private ParticleSystem pickupEffect; // Prefabrykat cz¹steczek

    protected override void Interact(Collider other)
    {
        base.Interact(other);
        GameManager.Instance?.PillPick();

        if (pickupEffect != null)
        {
            // Tworzymy cz¹steczki w miejscu obiektu
            Instantiate(pickupEffect, transform.position, Quaternion.identity);
        }

        Destroy(gameObject); // Usuwamy obiekt po zebraniu
    }
}
