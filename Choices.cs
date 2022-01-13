using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choices : MonoBehaviour
{
   public void ChooseToLeave()
    {
        SceneManager.LoadScene(21);
    }

    public void ChooseToContinue()
    {
        SceneManager.LoadScene(24);
    }

    public void ChooseToShutDown()
    {
        SceneManager.LoadScene(27);
    }

    public void ChooseToGivePower()
    {
        SceneManager.LoadScene(29);
    }
}
