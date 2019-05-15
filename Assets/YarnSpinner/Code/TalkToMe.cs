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
    bool ohDearLord;
    public int intToChangeConvoTo;
    // Start is called before the first frame update
    void Start()
    {
        drScript = dr.GetComponent<DialogueRunner>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ohDearLord)
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
                    /*
                    drScript.Stop();
                    drScript.Clear();

                    var temp = drScript.sourceText[0];
                    drScript.sourceText[0] = drScript.sourceText[intToChangeConvoTo];
                    drScript.sourceText[intToChangeConvoTo] = temp;
                    drScript.SelfHatredMachine();
                    */
                    drScript.startNode = startNode;
                    startDialog();
                    dialogueStarted = true;

                }
            } 
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            ohDearLord = true;
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
            ohDearLord = false;
        }
    }

    void startDialog()
    {
        FindObjectOfType<DialogueRunner>().StartDialogue();
    }
}
