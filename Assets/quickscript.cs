using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class quickscript : MonoBehaviour
{
    public GameObject speech;
    public GameObject fade;
    float opacity = 1;
    bool fun = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speech.GetComponent<TextMeshPro>().text == "Surprise!!!")
        {
            fun = true;
        }
        if (fun)
        {
            if (opacity > 0)
            {
                opacity -= 0.1f;
            }
        }
        Color ello = fade.GetComponent<SpriteRenderer>().color;
        fade.GetComponent<SpriteRenderer>().color = new Color(ello.r, ello.g, ello.b, opacity);

        if(speech.GetComponent<TextMeshPro>().text == ".....")
        {
            SceneManager.LoadScene("Saturday2");
        }
    }
}
