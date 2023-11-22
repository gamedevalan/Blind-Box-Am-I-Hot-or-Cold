using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIceGround : MonoBehaviour
{
    public int health;
    public int projectileElement;
    public ParticleSystem deathEnemy;
    Color color1;
    private Color colorTo;

    private void Start()
    {
        ColorUtility.TryParseHtmlString("#007FFF", out color1);
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        projectileElement = Weapon.projectileElement;
        if (hit.gameObject.tag == "Bullet")
        {
            if (projectileElement == 1)
            {
                Debug.Log("IceEnemy");
                TakeDamage(10);
            }

        }
    }

    public void TakeDamage(int damage)
    {

        if (projectileElement == 1)
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
        var main = deathEnemy.main;
        colorTo = color1;
        main.startColor = colorTo;
        Instantiate(deathEnemy, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
