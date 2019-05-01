using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Movement : MonoBehaviour
{
    public float step = 1;
    public GameObject dr;
    bool dialogueStarted = false;

    public float top;
    public float bottom;

    public float right, left, maxRight, maxLeft;

    public int currentScene = 1;

    public float cameraSpeed = 5f;

    public GameObject gm;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;

        //DialogueRunner drScript = dr.GetComponent<DialogueRunner>();

        if (Input.GetKey(KeyCode.A) && pos.x > maxLeft)
        {
            pos.x -= step;
        }

        if (Input.GetKey(KeyCode.D) && pos.x < maxRight) 
        {
            pos.x += step;
        }

        if (Input.GetKey(KeyCode.S) && pos.y > bottom)
        {
            pos.y -= step;
        }

        if (Input.GetKey(KeyCode.W) && pos.y < top)
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

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Door2"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("in front of door but " + gm.GetComponent<CameraControl>().currentScene);
                gm.GetComponent<CameraControl>().currentScene = 3;
            }
        }
    }


    void startDialog()
    {
        FindObjectOfType<DialogueRunner>().StartDialogue();
    }

}
