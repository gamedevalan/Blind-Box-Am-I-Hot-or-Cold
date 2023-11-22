using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrustUI : MonoBehaviour
{
    public GameObject fall;

    // Start is called before the first frame update
    void Start()
    {
        fall.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            fall.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(6);
        Destroy(fall);
    }
}
