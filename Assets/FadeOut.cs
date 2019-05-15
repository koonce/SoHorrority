using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity
{
    public class FadeOut : MonoBehaviour
    {

        bool fade = false;

        public GameObject demon1, demon2, demon3;

        public GameObject fadeOut;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (fade)
            {
                Color color = fadeOut.GetComponent<SpriteRenderer>().color;
                color.a += .1f;
                fadeOut.GetComponent<SpriteRenderer>().color = color;
                Debug.Log(color.a);
                if (color.a>5f)
                {
                    Application.Quit();
                }
            }
        }


        [YarnCommand("Demons")]
        public void EnterDemons()
        {
            demon1.SetActive(true);
            demon2.SetActive(true);
            demon3.SetActive(true);
        }

        [YarnCommand("FadeOut")]
        public void JustQuit()
        {
            fade = true;
        }
    }

}
