using UnityEngine.UI;
using UnityEngine;
using System;
using UnityEditor;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody2D rb;
    public float checkRadius;

    private bool touchingGoal;
    public Transform GoalCheck;
    public LayerMask whatisGoal;

    private bool touchingCoin1;
    public Transform CoinCheck;
    public LayerMask whatisCoin1;

    private bool touchingCoin2;
    public LayerMask whatisCoin2;

    private bool touchingCoin3;
    public LayerMask whatisCoin3;

    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;

    public GameObject player;

    public float amountOfCoins;
    public int coins = 1;


    public PlayerMovement movement;
    private Renderer rend;
    private Color colorTo;

    Color color1;
    Color color2;
    

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.white;
        ColorUtility.TryParseHtmlString("#007FFF", out color1);
        ColorUtility.TryParseHtmlString("#C573F8", out color2);
    }

    void FixedUpdate()
    { 

        touchingGoal = Physics2D.OverlapCircle(GoalCheck.position, checkRadius, whatisGoal);
        amountOfCoins = ScoreManager.score;
        if (amountOfCoins== 3)
       {
            if (touchingGoal == true)
            {
                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
                rb.velocity = Vector3.zero;
                FindObjectOfType<GameManage>().CompleteLevel();
                //FindObjectOfType<Timer>().Finish();
            }
        }

        if (amountOfCoins==0 || amountOfCoins == 1)
        {
            colorTo = color1;
            rend.material.color = colorTo;
        }

        if (amountOfCoins==2)
        {
            colorTo = color2;
            rend.material.color = colorTo;
        }

        if (amountOfCoins ==3)
        {
            colorTo = Color.red;
            rend.material.color = colorTo;
        }



        touchingCoin1 = Physics2D.OverlapCircle(CoinCheck.position, checkRadius, whatisCoin1);
        if (touchingCoin1 == true)
        {
            SoundManagerScript.PlaySound("Key");
            Destroy(coin1);
            ScoreManager.instance.ChangeScore(coins);
        }

        touchingCoin2 = Physics2D.OverlapCircle(CoinCheck.position, checkRadius, whatisCoin2);
        if (touchingCoin2 == true)
        {
            SoundManagerScript.PlaySound("Key");
            Destroy(coin2);
            ScoreManager.instance.ChangeScore(coins);
        }

        touchingCoin3 = Physics2D.OverlapCircle(CoinCheck.position, checkRadius, whatisCoin3);
        if (touchingCoin3 == true)
        {
            SoundManagerScript.PlaySound("Key");
            Destroy(coin3);
            ScoreManager.instance.ChangeScore(coins);
        }
    }


        void OnCollisionEnter2D(Collision2D hit)
        {
            if (hit.gameObject.tag == "EnemyIce")
            {
                Debug.Log("IceEnemy");
                FindObjectOfType<FollowPlayerDeath>().Death();
                FindObjectOfType<GameManage>().EndGameObstacles();
            }


        if (hit.gameObject.tag == "EnemyFire")
            {
                Debug.Log("FireEnemy");
                FindObjectOfType<FollowPlayerDeath>().Death();
                FindObjectOfType<GameManage>().EndGameObstacles();
            }

        if (hit.gameObject.tag == "EnemyAttack")
        {
            Debug.Log("Poison");
            FindObjectOfType<FollowPlayerDeath>().Death();
            FindObjectOfType<GameManage>().EndGameObstacles();
        }


    }


}
