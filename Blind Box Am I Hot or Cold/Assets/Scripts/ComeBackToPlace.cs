using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeBackToPlace : MonoBehaviour
{
    public float xValue;
    public float yValue;
    public GameObject player;
    public GameObject sendBackBox;

    private void Start()
    {
        sendBackBox.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.transform.position = new Vector3(xValue, yValue);
            Destroy(gameObject);
        }
    }


}
