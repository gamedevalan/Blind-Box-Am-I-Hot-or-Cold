using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public float lifeTime;
    private Renderer bullet;
    private TrailRenderer trailRender;
    private Color colorTo;

    public int damage = 10;

    Color ice;
    Color fire;
    public int projectileElement;

    public GameObject enemyHit;
    public GameObject wallHit;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Renderer>();
        trailRender = GetComponent<TrailRenderer>();
        ColorUtility.TryParseHtmlString("#007FFF", out ice);
        ColorUtility.TryParseHtmlString("#FF0000", out fire);

        projectileElement = Weapon.projectileElement;



        if (projectileElement == 1)
        {
            colorTo = ice;
            bullet.material.color = colorTo;
            trailRender.startColor = colorTo;
            trailRender.endColor = Color.white;
            Go();
        }

        if (projectileElement == 0)
        {
            colorTo = fire;
            bullet.material.color = colorTo;
            trailRender.startColor = colorTo;
            trailRender.endColor = Color.yellow;
            Go();
        }
    }



    public void Go()
    {
        rb.velocity = transform.right * speed;
        StartCoroutine(WaitThenDie());
    }


    private void OnCollisionEnter2D(Collision2D hit)
    {
       
            if (hit.gameObject.tag == "EnemyIce")
            {
            if (projectileElement == 1)
            {
                Debug.Log("IceEnemy");
                Instantiate(enemyHit, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            else
            {
                Instantiate(wallHit, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            }

        if (hit.gameObject.tag == "IceBox")
        {
            if (projectileElement == 1)
            {
                Debug.Log("IceBox");
                Instantiate(enemyHit, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            else
            {
                Instantiate(wallHit, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }

        if (hit.gameObject.tag == "FireBox")
        {
            if (projectileElement == 0)
            {
                Debug.Log("FireBox");
                Instantiate(enemyHit, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            else
            {
                Instantiate(wallHit, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }


        if (hit.gameObject.tag == "EnemyFire")
            {
            if (projectileElement == 0)
            {
                Debug.Log("FireEnemy");
                Instantiate(enemyHit, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            else
            {
                Instantiate(wallHit, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            }
            

            if (hit.gameObject.tag == "Ground")
            {
               Instantiate(wallHit, transform.position, transform.rotation);
               Destroy(gameObject);
            }


            if (hit.gameObject.tag == "EnemyAttack")
            {
               Instantiate(wallHit, transform.position, transform.rotation);
               Destroy(gameObject);
            }




    }

    IEnumerator WaitThenDie()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

}
