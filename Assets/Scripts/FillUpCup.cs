using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

    public class FillUpCup : MonoBehaviour
    {

        bool cupFull = false;

        public Sprite fillCup, emptyCup, bloodCup;

        public int drinks = 0;

        public GameObject background;
        public Sprite dizzyBackground;

        public GameObject dr;
        DialogueRunner drScript;

        public string node;

        float speed = 1.0f; //how fast it shakes
        float amount = 1.0f; //how much it shakes

        public bool start = true;

        public int current = 0;

        // Start is called before the first frame update
        void Start()
        {
            drScript = dr.GetComponent<DialogueRunner>();
        }

        // Update is called once per frame
        void Update()
        {
            if (!cupFull && !start)
            {
                if (transform.position.y < -11)
                {
                    if (drinks > 3 && current == 1)
                    {
                        node = "BloodShotsFirst";
                        drScript.startNode = node;
                        startDialog();
                        start = true;
                    }
                    else if (drinks > 7 && current == 2)
                    {
                        node = "BloodShotsSecond";
                        drScript.startNode = node;
                        startDialog();
                        GetComponent<SpriteRenderer>().sprite = bloodCup;
                        background.GetComponent<SpriteRenderer>().sprite = dizzyBackground;
                        start = true;

                }
                    else if (drinks > 11 && current == 3)
                    {
                        node = "BloodShotsThird";
                        drScript.startNode = node;
                        startDialog();
                        start = true;
                    }
                    else
                    {
                        GetComponent<SpriteRenderer>().sprite = fillCup;
                    }
                    cupFull = true;
                }
            }

            if (cupFull)
            {
                if (transform.position.y > 8)
                {
                    GetComponent<SpriteRenderer>().sprite = emptyCup;
                    drinks++;
                    cupFull = false;
                }
            }


        }

        void startDialog()
        {
            FindObjectOfType<DialogueRunner>().StartDialogue();
        }
    }

