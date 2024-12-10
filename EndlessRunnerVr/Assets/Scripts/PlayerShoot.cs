using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerShoot : MonoBehaviour 
{
    public static Action shootInput;
    [SerializeField] Transform muzzle;

    private void Update()
    {   
        if (Input.GetMouseButtonDown(0) && GameManager.Instance)
        {
            int currentAmmo = GameManager.Instance.currentAmmo;
            GameManager.Instance.UseBullet();

            if (Physics.Raycast(muzzle.position, transform.forward, out RaycastHit hitInfo, GameManager.Instance.maxDistance))
            {
                Debug.Log("Hit: " + hitInfo.collider.name + " " + hitInfo.collider.tag);

                if (hitInfo.collider.tag == "Obstacle" && currentAmmo > 0)
                {
                    hitInfo.transform.gameObject.SetActive(false);

                }
            }
        }
    }
}