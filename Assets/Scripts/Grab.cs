using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grab : MonoBehaviour
{
    public string nextScene;

    public GameObject name;

    public GameObject fade;

    public float fadeSpeed = .1f;

    bool next = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (next)
        {
            Color color = fade.GetComponent<SpriteRenderer>().color;
            color.a += fadeSpeed;
            fade.GetComponent<SpriteRenderer>().color = color;

            Debug.Log("fade is " + color.a);
            if (color.a>=6)
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            name.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("k go to next scene");

                next = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        name.SetActive(false);
    }
}
