using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    public void Begin()
    {
     SceneManager.LoadScene(1);
    }

    public void Begin2()
    {
        SceneManager.LoadScene(7);
    }

    public void Begin3()
    {
        SceneManager.LoadScene(13);
    }

    public void Begin4()
    {
        SceneManager.LoadScene(19);
    }
}
