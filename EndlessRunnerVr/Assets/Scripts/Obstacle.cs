using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : TriggerEnterBase
{
    protected override void Interact(Collider other)
    {
        base.Interact(other);
        //TakeDamage takeDamage = other.GetComponent<TakeDamage>();
        //if (takeDamage != null)
        //{
        //    takeDamage.TriggerDamage();
        //}
    
        GameManager.Instance?.ReduceLife();
        if(GameManager.Instance?.Lifes<= 0)
        {
            //Koniec gry tutaj
        }
    }
}