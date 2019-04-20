using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Movement : MonoBehaviour
{
    public float step = 1;
    public GameObject dr;
    bool dialogueStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //DialogueRunner drScript = dr.GetComponent<DialogueRunner>();
        Vector3 pos = this.transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= step;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += step;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= step;
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += step;
        }

        this.transform.position = pos;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            if (!dialogueStarted)
            {
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
