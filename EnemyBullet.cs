using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    public float lifeTime;
    public GameObject enemyBullet;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * speed;
        StartCoroutine(WaitThenDie());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player Killed");
            Destroy(enemyBullet);
        }


        if (collision.gameObject.tag == "Ground")
        {
            Destroy(enemyBullet);
        }

        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(enemyBullet);
        }
    }

IEnumerator WaitThenDie()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
