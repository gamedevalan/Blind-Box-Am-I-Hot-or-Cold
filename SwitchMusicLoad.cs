using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicLoad : MonoBehaviour
{
    public AudioClip newTrack;

    private MusicBackground theAM;

    private void Start()
    {
        theAM = FindObjectOfType<MusicBackground>();

        if (newTrack!=null)
        {
            theAM = FindObjectOfType<MusicBackground>();
            theAM.ChangeBGM(newTrack);
        }
    }
}
