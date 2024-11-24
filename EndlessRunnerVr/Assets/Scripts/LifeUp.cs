using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUp : TriggerEnterBase
{
    protected override void Interact(Collider other)
    {
        base.Interact(other);
        GameManager.Instance?.PillPick();
    }
}
