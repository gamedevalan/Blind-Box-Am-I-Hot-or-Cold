using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingButtons : MonoBehaviour
{
    public void GoBackToTheMenu()
    {
        SceneManager.LoadScene(0);
    }
}
