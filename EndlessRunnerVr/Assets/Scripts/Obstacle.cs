using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : TriggerEnterBase
{
    protected override void Interact(Collider other)
    {
        base.Interact(other);
        GameManager.Instance?.ReduceLife();
        if(GameManager.Instance?.Lifes<= 0)
        {
            //Koniec gry tutaj
        }
    }
}