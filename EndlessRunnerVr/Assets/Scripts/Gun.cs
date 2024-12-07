using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
    }

    public void Shoot()
    {
        Debug.Log("Shoot");
    }
}