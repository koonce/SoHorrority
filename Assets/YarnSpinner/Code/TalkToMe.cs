using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TalkToMe : MonoBehaviour
{
    DialogueRunner drScript;
    public GameObject dr;

    public GameObject name;
    public GameObject name2;

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

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            name.SetActive(true);
            if (name2 != null)
            {
                name2.SetActive(true);
            }
            if (!dialogueStarted)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    drScript.startNode = startNode;
                    startDialog();
                    dialogueStarted = true;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            name.SetActive(false);
            if (name2 != null)
            {
                name2.SetActive(false);
            }
        }
    }

    void startDialog()
    {
        FindObjectOfType<DialogueRunner>().StartDialogue();
    }
}
