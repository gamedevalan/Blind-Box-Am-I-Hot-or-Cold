using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBox : MonoBehaviour
{
    public int health;
    public int projectileElement;
    public GameObject character;
    public ParticleSystem deathBoxFire;


    private void OnCollisionEnter2D(Collision2D hit)
    {
        projectileElement = Weapon.projectileElement;
        if (hit.gameObject.tag == "Bullet")
        {
            if (projectileElement == 0)
            {
                Debug.Log("FireBox");
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
        SoundManagerScript.PlaySound("BoxExplode");
        Instantiate(deathBoxFire, transform.position, Quaternion.identity);
        character.SetActive(false);
    }
}
