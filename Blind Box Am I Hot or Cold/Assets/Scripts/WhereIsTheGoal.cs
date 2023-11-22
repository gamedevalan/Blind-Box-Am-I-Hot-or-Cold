using UnityEngine.UI;
using UnityEngine;
using System;

public class WhereIsTheGoal : MonoBehaviour
{
    public Transform player;
    public Transform Goal;
    public Text scoreText1;
    public Text scoreText2;
    public float distanceY;
    public float distanceX;

    public float projectileElement;
    public Text element;

    private Color colorTo;

    Color ice;
    Color fire;

    private void Start()
    {
        ColorUtility.TryParseHtmlString("#007FFF", out ice);
        ColorUtility.TryParseHtmlString("#FF0000", out fire);
    }

    // Update is called once per frame
    void Update()
    {
        distanceY = (Goal.transform.position.y - player.transform.position.y);

        if (distanceY > 0)
        {
            distanceY = Math.Abs(distanceY);
            scoreText1.text = distanceY.ToString("0") + " feet up";
        }
        else if (distanceY < 0)
        {
            distanceY=Math.Abs(distanceY);
            scoreText1.text = distanceY.ToString("0") + " feet down";
        }
   


        distanceX = (Goal.transform.position.x - player.transform.position.x);

        if (distanceX > 0)
        {
            distanceX = Math.Abs(distanceX);
            scoreText2.text = distanceX.ToString("0") + " feet right";
        }
        else if (distanceX < 0)
        {
            distanceX = Math.Abs(distanceX);
            scoreText2.text = distanceX.ToString("0") + " feet left";
        }

        projectileElement = Weapon.projectileElement;

        if (projectileElement == 1)
        {
            colorTo = ice;
            element.color = colorTo;
            element.text = "ICE";
        }

        if (projectileElement == 0)
        {
            colorTo = fire;
            element.color = colorTo;
            element.text = "FIRE";
        }
    }
}
