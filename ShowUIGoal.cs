using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUIGoal : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject arrow;
    public GameObject uiObjectWelcome;
    public GameObject uiObjectWelcome2;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
        uiObjectWelcome.SetActive(true);
        uiObjectWelcome2.SetActive(true);
        arrow.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            uiObjectWelcome.SetActive(false);
            uiObjectWelcome2.SetActive(false);
            arrow.SetActive(false);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(10);
        Destroy(uiObject);
    }
}
