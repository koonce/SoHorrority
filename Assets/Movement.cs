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

    public TextAsset convo;

    DialogueRunner drScript;

    bool onStairs = false;

    public bool firstFloor = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!firstFloor)
        {
            maxLeft = -11f;
            maxRight = 10f;
            top = 10.83f;
            bottom = 9.22f;
        }
        else
        {
            maxLeft = -29.6f;
            maxRight = 29.7f;
            top = -0.83f;
            bottom = -3.67f;
        }

        Vector3 pos = this.transform.position;

        drScript = dr.GetComponent<DialogueRunner>();

        if (!drScript.isDialogueRunning)
        {
            if (Input.GetKey(KeyCode.A) && pos.x > maxLeft)
            {
                pos.x -= step;
                this.GetComponent<SpriteRenderer>().flipX = false;
            }

            if (Input.GetKey(KeyCode.D) && pos.x < maxRight)
            {
                pos.x += step;
                this.GetComponent<SpriteRenderer>().flipX = true;
            }

            if (Input.GetKey(KeyCode.S) && (pos.y > bottom|| onStairs))
            {
                pos.y -= step;
            }

            if (Input.GetKey(KeyCode.W) && (pos.y < top || onStairs))
            {
                pos.y += step;
            }

            this.transform.position = pos;
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Stairs"))
        {
            onStairs = true;
        }

        if (collision.CompareTag("Door2"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("in front of door but " + gm.GetComponent<CameraControl>().currentScene);
                gm.GetComponent<CameraControl>().currentScene = 3;
                this.gameObject.transform.position = new Vector3(-20.56f, 8.05f, 0);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Stairs"))
        {
            onStairs = false;
        }
    }


}
