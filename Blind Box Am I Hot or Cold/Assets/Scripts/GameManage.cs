using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay1 = 0.5f;
    public float restartDelay2 = 2f;
    public GameObject completeLevelUI;
    public PlayerMovement movement;
    public GameObject goalText1;
    public GameObject goalText2;
    public GameObject goalText3;
    public GameObject anyText;
    public GameObject elementText;
    public GameObject timer;

    public ParticleSystem deathPlayer;

    public void CompleteLevel()
    {
        elementText.SetActive(false);
        completeLevelUI.SetActive(true);
        goalText1.SetActive(false);
        goalText2.SetActive(false);
        goalText3.SetActive(false);
        anyText.SetActive(false);
        elementText.SetActive(false);

    }

    public void EndGameFall()
    {
        if (gameHasEnded == false)
        {
            ScoreManager.score = 0;
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay1);
           
            //restart game
        }
    }

    public void EndGameObstacles()
    {
        if (gameHasEnded == false)
        {
            ScoreManager.score = 0;
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay2);
          
            //restart game
        }
    }

    public void PressRetry()
    {
        if (gameHasEnded == false)
        {
            ScoreManager.score = 0;
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", 1);
            
            //restart game
        }
    }

    void Restart()
    {
        var em = deathPlayer.emission;
        em.enabled = false;
        deathPlayer.Stop();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
