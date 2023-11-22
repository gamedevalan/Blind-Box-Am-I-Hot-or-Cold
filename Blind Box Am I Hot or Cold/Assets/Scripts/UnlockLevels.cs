using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockLevels : MonoBehaviour
{
    public static int whatLevels = 1;

    public void ForestLevelUnlocked()
    {
        whatLevels = 2;
    }

    public void FactoryLevelUnlocked()
    {
        whatLevels = 3;
    }

    public void ChoicesUnlocked()
    {
        whatLevels = 4;
    }

    public static void PasswordUnlocked()
    {
        whatLevels = 4;
    }
}
