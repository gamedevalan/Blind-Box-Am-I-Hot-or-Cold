using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject bullet;

    public float startShotTime;
    public float delayShotTime;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("ShootMissle", startShotTime, delayShotTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShootMissle()
    {
        Instantiate(bullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.80f), gameObject.transform.rotation);
    }
}