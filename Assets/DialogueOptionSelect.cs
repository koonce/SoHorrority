using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class DialogueOptionSelect : MonoBehaviour
{
    public GameObject dr;

    public int selection = 0;

    public string inputName;
    public UnityEngine.UI.Button[] button = new Button[2];

    public int amountOfOptions=2;

    // Start is called before the first frame update
    void Start()
    {
        //button[selection].Select();
        button[selection].OnSelect(null);

    }

    // Update is called once per frame
    void Update()
    {

        button[selection].Select();
        /*
        for (int i = 0; i < button.Length; i++)
        {
            if (i == selection)
            {
                button[selection].OnSelect(null);
                button[selection].Select();
            }
            else
            {
                button[selection].OnDeselect(null);
            }
        }
        */

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("selection: " + selection);
            selection -= 1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("selection: " + selection);
            selection += 1;
        }

        if (selection > amountOfOptions - 1)
        {
            selection = 0;
        }
        if (selection < 0)
        {
            selection = amountOfOptions - 1;
        }


        /*
        for (int i = 0; i < button.Length; i++)
        {
            if (i == selection)
            {
                button[selection].OnSelect(null);
            }
            else
            {
                //button[selection].OnDeselect(null);
            }
        }
        */

        if (dr.GetComponent<DialogueUI>().deciding)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                button[selection].onClick.Invoke();
            }
        }
    }
}
