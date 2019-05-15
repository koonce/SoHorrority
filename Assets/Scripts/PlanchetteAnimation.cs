using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity
{
    public class PlanchetteAnimation : MonoBehaviour
    {

        DialogueRunner drScript;
        public GameObject dr;

        public int animIndex = 0;

        public AnimationClip[] anim = new AnimationClip[6];

        public GameObject planchette;

        string startNode = "106";

        public bool ouijaTime = false;

        public bool yes;
        public bool loveu;
        public bool missu;
        public bool belong;

        // Start is called before the first frame update
        void Start()
        {
            
            for (int i = 0; i < anim.Length; i++)
            {
                anim[i].wrapMode = WrapMode.Once;
            }

            yes = false;
            loveu = false;
            missu = false;
            belong = false;

            GetComponent<Animator>().SetInteger("animIndex", 0);
            
        }

        // Update is called once per frame
        void Update() {
            drScript = dr.GetComponent<DialogueRunner>();
            /*
            if (animIndex == 0 && ouijaTime)
            {
                if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    // Avoid any reload.
                   //drScript.startNode = "106";
                   startDialog();
                    ouijaTime = false;
                    animIndex = 0;
                }
            }

            if (animIndex == 2 && ouijaTime)
            {
                if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    // Avoid any reload.
                    startNode = "108";
                    drScript.startNode = startNode;
                    startDialog();
                    ouijaTime = false;
                    animIndex = 0;
                }
            }

            if (animIndex == 1 && ouijaTime)
            {
                if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    // Avoid any reload.
                    startNode = "106";
                    drScript.startNode = startNode;
                    startDialog();
                    ouijaTime = false;
                    animIndex = 0;
                }
            }

            if (animIndex == 3 && ouijaTime)
            {
                if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    // Avoid any reload.
                    startNode = "107";
                    drScript.startNode = startNode;
                    startDialog();
                    ouijaTime = false;
                    animIndex = 0;
                }
            }

            if (animIndex==4 && ouijaTime)
            {
                if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    // Avoid any reload.
                    startNode = "109";
                    drScript.startNode = startNode;
                    startDialog();
                    ouijaTime = false;
                    animIndex = 0;
                }
            }
            */

            if(belong && ouijaTime) {
                startNode = "109";
                drScript.startNode = startNode;
                startDialog();
                ouijaTime = false;
                belong = false;
            } else if(missu && ouijaTime) {
                startNode = "108";
                drScript.startNode = startNode;
                startDialog();
                ouijaTime = false;
                missu = false;
            } else if(loveu && ouijaTime) {
                startNode = "107";
                drScript.startNode = startNode;
                startDialog();
                ouijaTime = false;
                loveu = false;
            } else if(yes && ouijaTime) {
                startNode = "106";
                drScript.startNode = startNode;
                startDialog();
                ouijaTime = false;
                yes = false;
            }
            
            GetComponent<Animator>().SetInteger("animIndex", animIndex);
        }

        [YarnCommand("AnimateIt")]
        public void MovePlanchette()
        {
            animIndex = 1;
            ouijaTime = true;
            
        }


        [YarnCommand("AnimateIt2")]
        public void MovePlanchette2()
        {
            animIndex = 2;
            ouijaTime = true;
            
        }

        [YarnCommand("AnimateIt3")]
        public void MovePlanchette3() {
            animIndex = 3;
            ouijaTime = true;
            
        }

        [YarnCommand("AnimateIt4")]
        public void MovePlanchette4() {
            animIndex = 4;
            ouijaTime = true;
            
        }

        void startDialog()
        {
            FindObjectOfType<DialogueRunner>().StartDialogue();
        }

        public void resetPlanchette(int index) {
            if(animIndex == 1) {
                yes = true;
            } else if (animIndex == 2) {
                loveu = true;
            } else if (animIndex == 3) {
                missu = true;
            } else if (animIndex == 4) {
                belong = true;
            }

            index = 0;

            animIndex = index;
            GetComponent<Animator>().SetInteger("animIndex", animIndex);
        }
    }
}
