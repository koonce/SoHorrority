using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grab : MonoBehaviour
{
    public string nextScene;

    public GameObject name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            name.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("k go to next scene");
                SceneManager.LoadScene(nextScene);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        name.SetActive(false);
    }
}
