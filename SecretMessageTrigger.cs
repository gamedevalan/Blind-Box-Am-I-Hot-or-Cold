using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretMessageTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject talk;
    public GameObject trigger;
    public GameObject sendBackBox;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.SetActive(false);
            talk.SetActive(true);
            FindObjectOfType<DialogueTriggerSecret>().TriggerDialogue();
        }
    }

    public void StopTalking()
    {
        Destroy(trigger);
        talk.SetActive(false);
        player.SetActive(true);
        sendBackBox.SetActive(true);
    }
}
