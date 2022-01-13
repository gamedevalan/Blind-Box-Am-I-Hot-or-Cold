using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject information;
    public GameObject credit;
    public GameObject levels;

    public Button forest;
    public Button factory;

    public AudioSource forestSounds;
    public AudioSource factorySounds;

    public int whatLevels;
    public GameObject choose;

    void Start()
    {
        forest.interactable = false;
        factory.interactable = false;

        forestSounds.mute= true;
        factorySounds.mute = true;

        choose.SetActive(false);
    }

     void Update()
    {
        whatLevels = UnlockLevels.whatLevels;

        if (whatLevels==2)
        {
            forest.interactable = true;
            factory.interactable = true;

            forestSounds.mute = false;
            factorySounds.mute = false;
        }

        if (whatLevels == 3)
        {
            forest.interactable = true;
            factory.interactable = true;

            forestSounds.mute = false;
            factorySounds.mute = false;
        }

        if (whatLevels == 4)
        {
            forest.interactable = true;
            factory.interactable = true;

            forestSounds.mute = false;
            factorySounds.mute = false;

            choose.SetActive(true);

        }
    }

    public void StartGame()
    {
        Debug.Log("Level Show");
        levels.SetActive(true);
    }

    public void HideStartGame()
    {
        Debug.Log("Level Hide");
        levels.SetActive(false);
    }

    public void Info()
    {
        Debug.Log("Info Show");
        information.SetActive(true);
    }

    public void HideInfo()
    {
        Debug.Log("Info Hide");
        information.SetActive(false);
    }

    public void Credit()
    {
        Debug.Log("Credit Show");
        credit.SetActive(true);
    }

    public void HideCredit()
    {
        Debug.Log("Credit Hide");
        credit.SetActive(false);
    }

    public void EnvironmentOne()
    {
        FindObjectOfType<LevelChanger>().Begin();
    }
    public void EnvironmentTwo()
    {
        FindObjectOfType<LevelChanger>().Begin2();
    }
    public void EnvironmentThree()
    {
        FindObjectOfType<LevelChanger>().Begin3();
    }
    public void Choice()
    {
        FindObjectOfType<LevelChanger>().Begin4();
    }
}
