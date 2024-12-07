using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "Weapon/Gun")]
public class Weapon : ScriptableObject
{
    [Header("Shooting")]
    public float maxDistance;

    [Header("Reloading")]
    public int currentAmmo;
    public int magSize;
}
