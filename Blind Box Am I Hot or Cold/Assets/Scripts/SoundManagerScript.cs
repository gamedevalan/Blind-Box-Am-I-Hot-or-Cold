using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip keyPickUpSound, shoot, playerDeath, enemyDeath, boxExplode;
    //public static AudioClip jumpSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        //jumpSound = Resources.Load<AudioClip>("Jump");
        keyPickUpSound = Resources.Load<AudioClip>("Key");
        shoot = Resources.Load<AudioClip>("Bullet");
        playerDeath= Resources.Load<AudioClip>("PlayerDeath");
        enemyDeath= Resources.Load<AudioClip>("EnemyDeath");
        boxExplode = Resources.Load<AudioClip>("EnemyDeath");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
           // case "Jump":
            //    audioSrc.PlayOneShot(jumpSound);
             //   break;

            case "Key":
                audioSrc.PlayOneShot(keyPickUpSound);
                break;

            case "Bullet":
                audioSrc.PlayOneShot(shoot);
                break;

            case "PlayerDeath":
                audioSrc.PlayOneShot(playerDeath);
                break;

            case "EnemyDeath":
                audioSrc.PlayOneShot(enemyDeath);
                break;

            case "BoxExplode":
                audioSrc.PlayOneShot(enemyDeath);
                break;
        }
    }
}
