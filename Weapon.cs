using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public static int projectileElement=1;

    private void Start()
    {
        projectileElement = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            projectileElement = 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            projectileElement = 0;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        SoundManagerScript.PlaySound("Bullet");
        Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
    }
}
