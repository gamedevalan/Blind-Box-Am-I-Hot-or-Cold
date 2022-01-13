using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClicks : MonoBehaviour
{
    public AudioSource click;
    public AudioClip clickEffect;

    public AudioSource hover;
    public AudioClip hoverEffect;

    public AudioSource menuClick;
    public AudioClip menuClickEffect;

    public void ClickSound()
    {
        click.PlayOneShot(clickEffect);
    }

    public void HoverSound()
    {
        hover.PlayOneShot(hoverEffect);
    }

    public void MenuClickSound()
    {
        menuClick.PlayOneShot(menuClickEffect);
    }
}
