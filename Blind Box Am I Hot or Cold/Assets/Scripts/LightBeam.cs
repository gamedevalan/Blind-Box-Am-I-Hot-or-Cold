using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBeam : MonoBehaviour
{

    public float distance;

    public LineRenderer lineOfSight;

    public Transform startPoint;

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, -transform.up, distance);

        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            lineOfSight.SetPosition(1,hitInfo.point);

            if (hitInfo.collider.CompareTag("Player"))
            {
                FindObjectOfType<FollowPlayerDeath>().Death();
                FindObjectOfType<GameManage>().EndGameObstacles();
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + -transform.up * distance, Color.green);
            lineOfSight.SetPosition(1, transform.position + -transform.up * distance);
        }

        lineOfSight.SetPosition(0, startPoint.position);
    }
}
