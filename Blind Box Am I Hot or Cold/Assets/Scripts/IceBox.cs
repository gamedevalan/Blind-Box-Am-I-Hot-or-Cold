using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBox : MonoBehaviour
{
    public int health;
    public int projectileElement;
    public GameObject character;
    public ParticleSystem deathBoxIce;


    private void OnCollisionEnter2D(Collision2D hit)
    {
        projectileElement = Weapon.projectileElement;
        if (hit.gameObject.tag == "Bullet")
        {
            if (projectileElement == 1)
            {
                Debug.Log("IceBox");
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
        SoundManagerScript.PlaySound("BoxExplode");
        Instantiate(deathBoxIce, transform.position, Quaternion.identity);
        character.SetActive(false);
    }
}
