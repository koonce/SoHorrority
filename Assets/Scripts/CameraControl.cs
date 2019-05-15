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

    
    public Vector3[] cameraPos = new Vector3[6];

    public GameObject fadeScreen;

    public float fadeSpeed;

    float secondFloor = 9.22f;

    bool fade = false;

    // Start is called before the first frame update
    void Start()
    {
        cameraPos[0] = new Vector3(-20.46f, 1f, -10f);
        cameraPos[1] = new Vector3(-0f, 1f, -10f);
        cameraPos[2] = new Vector3(20.4f, 1f, -10f);
       // cameraPos[3] = new Vector3(40.9f, 1f, -10f);
        cameraPos[3] = new Vector3(-20.46f, 12.44f, -10f);
        cameraPos[4] = new Vector3(0f, 12.44f, -10f);
        cameraPos[5] = new Vector3(20.4f, 12.44f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        //Color color = fadeScreen.GetComponent<SpriteRenderer>().color;
        

        if (player.transform.position.y>8.5f && currentScene == 1)
        {
            currentScene = 4;

        }
        if (player.transform.position.x < left) {
            currentScene--;
        } 
        
        if(player.transform.position.x > right) {
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
            player.GetComponent<Movement>().firstFloor = true;
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
        else if (currentScene == 4)
        {

            /*
            if (!fade)
            {
                FadeOut();
            }
            */

            //Debug.Log("fade: " + fadeScreen.GetComponent<SpriteRenderer>().color.a);


            //if (fadeScreen.GetComponent<SpriteRenderer>().color.a >= 224)
            //{
            player.GetComponent<Movement>().firstFloor = false;
            cam.transform.position = Vector3.Lerp(cam.transform.position, cameraPos[currentScene], Time.deltaTime * cameraSpeed);
            left = -11f;
            right = 10f;

            if (player.transform.position.y<secondFloor)
            {
                currentScene = 1;
            }
                

            //    Debug.Log("SWITCH");
            //    fade = true;

            //}


        }

        else if (currentScene == 3) {

            player.GetComponent<Movement>().firstFloor = false;
            cam.transform.position = Vector3.Lerp(cam.transform.position, cameraPos[currentScene], Time.deltaTime * cameraSpeed);
            left = -29.53f;
            right = -11f;
        }

        else if (currentScene == 5) {
            player.GetComponent<Movement>().firstFloor = false;
            cam.transform.position = Vector3.Lerp(cam.transform.position, cameraPos[currentScene], Time.deltaTime * cameraSpeed);
            left = 10f;
            right = 30.72f;
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
            color.a += Time.deltaTime * fadeSpeed;
        }
        fadeScreen.GetComponent<SpriteRenderer>().color = color;
    }
}
