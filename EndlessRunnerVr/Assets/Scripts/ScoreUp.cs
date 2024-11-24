using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : TriggerEnterBase
{
    protected override void Interact(Collider other)
    {
        base.Interact(other);
        GameManager.Instance?.CoinPick();
    }
}
