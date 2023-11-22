using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
   // public Text text;
    public static float score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance==null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coins)
    {
        score += coins;
        //text.text = score.ToString("0")+" coins collected";
    }
}
