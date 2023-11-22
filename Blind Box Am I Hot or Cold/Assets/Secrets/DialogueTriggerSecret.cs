using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerSecret : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<SecretDialogue>().StartDialogue(dialogue);
    }
}
