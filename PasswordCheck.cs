using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordCheck : MonoBehaviour
{
    private string password = "LY";
    public InputField input;

    public string userInput;

    public GameObject correct;
    public GameObject incorrect;


    private void Start()
    {
        correct.SetActive(false);
        incorrect.SetActive(false);
    }

    public void CheckPassword()
    {
        userInput = input.text;

        if (userInput != null)
        {
            if (userInput == password)
            {
                UnlockLevels.PasswordUnlocked();
                Debug.Log("Correct Password");
                correct.SetActive(true);
                incorrect.SetActive(false);
            }

            else
            {
                Debug.Log("Incorrect Password");
                incorrect.SetActive(true);
                correct.SetActive(false);

            }
        }
    }

}
