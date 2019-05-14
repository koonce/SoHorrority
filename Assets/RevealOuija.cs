using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Yarn.Unity
{
    public class RevealOuija : MonoBehaviour
    {
        float fadeSpeed = 5f;
        public GameObject fadeScreen;

        bool fade = false;

        public GameObject planchette;

        public Animator yes;

        

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (fade)
            {
                //Debug.Log("fading");
                FadeIn();
            }
        }

        void FadeIn()
        {
            Color color = fadeScreen.GetComponent<SpriteRenderer>().color;
            if (color.a >= 0)
            {
                color.a -= Time.deltaTime;// * fadeSpeed;
            }
            fadeScreen.GetComponent<SpriteRenderer>().color = color;
        }


        [YarnCommand("Reveal")]
        public void Show()
        {
            //Debug.Log("we fade");
            fade = true;
        }

        [YarnCommand("Ouija")]
        public void AnimateIt()
        {
            
        }

        [YarnCommand("ChangeScene")]
        public void nextScene()
        {
            SceneManager.LoadScene("Saturday");
        }

    }
}
