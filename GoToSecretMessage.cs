using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSecretMessage : MonoBehaviour
{
   public float xValue;
   public float yValue;
    public GameObject player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = new Vector3(xValue, yValue);
        Destroy(gameObject);
    }


}
