using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    public float distance;
    public LineRenderer lineOfSight;

    public Transform startPoint;
    public Transform endPoint;


    private void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position,transform.right,distance);

        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            lineOfSight.SetPosition(1, hitInfo.point);

            if (hitInfo.collider.CompareTag("Player"))
            {
                FindObjectOfType<FollowPlayerDeath>().Death();
                FindObjectOfType<GameManage>().EndGameObstacles();
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right*distance, Color.green);
            lineOfSight.SetPosition(1, endPoint.position);

        }

        lineOfSight.SetPosition(0, startPoint.position);
    }


}
