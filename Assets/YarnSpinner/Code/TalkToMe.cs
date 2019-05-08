using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TalkToMe : MonoBehaviour
{
    DialogueRunner drScript;
    public GameObject dr;

    public string startNode;

    bool dialogueStarted = false;

    public TextAsset convo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        drScript = dr.GetComponent<DialogueRunner>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!dialogueStarted)
            {
                drScript.startNode = startNode;
                startDialog();
                dialogueStarted = true;
            }
        }
    }

    void startDialog()
    {
        FindObjectOfType<DialogueRunner>().StartDialogue();
    }
}
