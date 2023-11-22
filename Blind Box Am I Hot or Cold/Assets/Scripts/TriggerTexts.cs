using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTexts : MonoBehaviour
{
    public GameObject words;

    // Start is called before the first frame update
    void Start()
    {
        words.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            words.SetActive(true);
            //StartCoroutine("WaitForSec");
        }
    }

   // IEnumerator WaitForSec()
   // {
       // yield return new WaitForSeconds(6);
        //Destroy(words);
  //  }
}
