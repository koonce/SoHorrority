using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public int currentScene = 1;
    float left, right;

    public float cameraSpeed = 5f;

    public GameObject player;

    public Camera cam;

    public Vector3[] cameraPos = new Vector3[5];

    public GameObject fadeScreen;

    public float fadeSpeed;

    bool fade = false;

    // Start is called before the first frame update
    void Start()
    {
        cameraPos[0] = new Vector3(-20.4f, 1f, -10f);
        cameraPos[1] = new Vector3(-.6f, 1f, -10f);
        cameraPos[2] = new Vector3(20.4f, 1f, -10f);
       // cameraPos[3] = new Vector3(40.9f, 1f, -10f);
        cameraPos[3] = new Vector3(-20.2f, 13.9f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        //Color color = fadeScreen.GetComponent<SpriteRenderer>().color;

        if (player.transform.position.x < left)
        {
            currentScene--;
        }

        if (player.transform.position.x > right)
        {
            currentScene++;
        }

        //currentScene = player.GetComponent<Movement>().currentScene;

        if (currentScene == 0)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, cameraPos[currentScene], Time.deltaTime * cameraSpeed);
            left = -29.53f;
            right = -11f;
        }
        else if (currentScene == 1)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, cameraPos[currentScene], Time.deltaTime * cameraSpeed);
            left = -11f;
            right = 10f;
        }
        else if (currentScene == 2)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, cameraPos[currentScene], Time.deltaTime * cameraSpeed);
            left = 10f;
            right = 30.72f;
        }
        /*
        else if (currentScene == 3)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, cameraPos[currentScene], Time.deltaTime * cameraSpeed);
            left = 30.72f;
            right = 50.4f;
        }
        */
        else if (currentScene == 3)
        {

            if (!fade)
            {
                FadeOut();
            }

            //Debug.Log("fade: " + fadeScreen.GetComponent<SpriteRenderer>().color.a);

            if (fadeScreen.GetComponent<SpriteRenderer>().color.a >= 224)
            {
                cam.transform.position = cameraPos[currentScene];

                Debug.Log("SWITCH");
                fade = true;
                
            }

            if (fade)
            {
                FadeIn();
            }

            
        }


    }

    void FadeIn()
    {
        Color color = fadeScreen.GetComponent<SpriteRenderer>().color;
        if (color.a <= 224)
        {
            color.a -= Time.deltaTime * fadeSpeed;
        }
        fadeScreen.GetComponent<SpriteRenderer>().color = color;
    }

    void FadeOut()
    {
        Color color = fadeScreen.GetComponent<SpriteRenderer>().color;
        if (color.a >= 0)
        {
            color.a += Time.deltaTime * fadeSpeed * 3f;
        }
        fadeScreen.GetComponent<SpriteRenderer>().color = color;
    }
}
