using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompleted : MonoBehaviour
{
    public Image retry;
    public Image retry2;
    public Image nextLevel;

    public void LoadNextLevel()
    {
        ScoreManager.score = 0;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartAgain()
    {
        retry.enabled = false;
        nextLevel.enabled = false;
        retry2.enabled = false;

        FindObjectOfType<FollowPlayerDeath>().Death();
        FindObjectOfType<GameManage>().PressRetry();
    }
}
