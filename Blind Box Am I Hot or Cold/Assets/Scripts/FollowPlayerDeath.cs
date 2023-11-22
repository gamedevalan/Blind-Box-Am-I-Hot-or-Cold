using UnityEngine;
using System.Collections;
using System;

public class FollowPlayerDeath : MonoBehaviour
{
    public Transform player;
    public ParticleSystem deathPlayer;
    public GameObject character;
    public float amountOfCoins;
    Color color1;
    Color color2;
    private Color colorTo;


    void Start()
    {
        deathPlayer = GetComponent<ParticleSystem>();
        deathPlayer.Stop();

        var em = deathPlayer.emission;
        em.enabled = false;

        ColorUtility.TryParseHtmlString("#007FFF", out color1);
        ColorUtility.TryParseHtmlString("#C573F8", out color2);
    }

    public void Death()
    {
        SoundManagerScript.PlaySound("PlayerDeath");
        deathPlayer.Stop();

        amountOfCoins = ScoreManager.score;
        var main = deathPlayer.main;

        if (amountOfCoins == 0 || amountOfCoins == 1)
        {
            colorTo = color1;
            main.startColor = colorTo;
        }

        if (amountOfCoins == 2)
        {
            colorTo = color2;
            main.startColor = colorTo;
        }

        if (amountOfCoins == 3)
        {
            colorTo = Color.red;
            main.startColor = colorTo;
        }

        var em = deathPlayer.emission;
        em.enabled = true;
        deathPlayer.Play();
            character.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
    }


}
