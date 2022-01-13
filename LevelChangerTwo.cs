using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangerTwo : MonoBehaviour
{
    public Animator animator;
    //private int levelToLoad;
    

    public void FadetoLevel(int levelIndex)
    {
        animator.SetTrigger("FadeOut");
    }

  //  public void OnFadeComplete()
   // {
    //    SceneManager.LoadScene(levelToLoad);
   // }
}
