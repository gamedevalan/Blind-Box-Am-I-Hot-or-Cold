using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireGround : MonoBehaviour
{
    public int health;
    public int projectileElement;
    public ParticleSystem deathEnemy2;
    Color color2;
    private Color colorTo;

    private void Start()
    {
        ColorUtility.TryParseHtmlString("#FF0000", out color2);
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        projectileElement = Weapon.projectileElement;
        if (hit.gameObject.tag == "Bullet")
        {
            if (projectileElement == 0)
            {
                Debug.Log("FireEnemy");
                TakeDamage(10);
            }

        }
    }

    public void TakeDamage(int damage)
    {

        if (projectileElement == 0)
        {
            health -= damage;
        }

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SoundManagerScript.PlaySound("EnemyDeath");
        var main = deathEnemy2.main;
        colorTo = color2;
        main.startColor = colorTo;
        Instantiate(deathEnemy2, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
