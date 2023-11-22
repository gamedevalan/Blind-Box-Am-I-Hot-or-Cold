using UnityEngine.UI;
using UnityEngine;
using System;

public class WhereIsCoin : MonoBehaviour
{
    public Transform player;
    public Transform Collectables1;
    public Text Coin1DistanceText1;
    public Text Coin1DistanceText2;
    public float Coin1distanceY;
    public float Coin1distanceX;

    // Update is called once per frame
    void Update()
    {
        Coin1distanceY = (Collectables1.transform.position.y - player.transform.position.y);

        if (Coin1distanceY > 0)
        {
            Coin1distanceY = Math.Abs(Coin1distanceY);
            Coin1DistanceText1.text = Coin1distanceY.ToString("0") + " feet up";
        }
        else if (Coin1distanceY < 0)
        {
            Coin1distanceY = Math.Abs(Coin1distanceY);
            Coin1DistanceText1.text = Coin1distanceY.ToString("0") + " feet down";
        }



        Coin1distanceX = (Collectables1.transform.position.x - player.transform.position.x);

        if (Coin1distanceX > 0)
        {
            Coin1distanceX = Math.Abs(Coin1distanceX);
            Coin1DistanceText2.text = Coin1distanceX.ToString("0") + " feet right";
        }
        else if (Coin1distanceX < 0)
        {
            Coin1distanceX = Math.Abs(Coin1distanceX);
            Coin1DistanceText2.text = Coin1distanceX.ToString("0") + " feet left";
        }


    }
}
