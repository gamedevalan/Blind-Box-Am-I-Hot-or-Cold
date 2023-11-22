using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class PauseScreen : MonoBehaviour
{
    public GameObject pause;
    public GameObject player;
    public GameObject retry;

    private void Start()
    {
        pause.SetActive(false);
    }
    public void Pause()
    {
        Debug.Log("Pause");
        pause.SetActive(true);
        player.SetActive(false);
        retry.SetActive(false);
    }

    public void ResumeGame()
    {
        Debug.Log("Resume");
        pause.SetActive(false);
        player.SetActive(true);
        retry.SetActive(true);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
