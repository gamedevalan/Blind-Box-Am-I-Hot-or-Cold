using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJumpUI : MonoBehaviour
{
    public GameObject walljump;

    // Start is called before the first frame update
    void Start()
    {
        walljump.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            walljump.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(6);
        Destroy(walljump);
    }
}
