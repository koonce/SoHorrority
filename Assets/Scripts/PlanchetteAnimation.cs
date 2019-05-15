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

        

        // Start is called before the first frame update
        void Start()
        {
            
            for (int i = 0; i < anim.Length; i++)
            {
                anim[i].wrapMode = WrapMode.Once;
            }
            
        }

        // Update is called once per frame
        void Update()
        {
            drScript = dr.GetComponent<DialogueRunner>();
            if (animIndex == 0 && ouijaTime)
            {
                if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    // Avoid any reload.
                   //drScript.startNode = "106";
                   startDialog();
                    ouijaTime = false;
                }
            }

            if (animIndex == 2 && ouijaTime)
            {
                if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    // Avoid any reload.
                    startNode = "107";
                    drScript.startNode = startNode;
                    startDialog();
                    ouijaTime = false;
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
                }
            }

            if (animIndex == 3 && ouijaTime)
            {
                if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    // Avoid any reload.
                    startNode = "108";
                    drScript.startNode = startNode;
                    startDialog();
                    ouijaTime = false;
                }
            }

            if ((animIndex==5 || animIndex==4) & ouijaTime)
            {
                if (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                {
                    // Avoid any reload.
                    startNode = "109";
                    drScript.startNode = startNode;
                    startDialog();
                    ouijaTime = false;
                }
            }
        }

        [YarnCommand("AnimateIt")]
        public void MovePlanchette()
        {
            animIndex++;
            this.GetComponent<Animation>().clip = anim[animIndex];
            ouijaTime = true;
           this.GetComponent<Animation>().Play();
        }


        [YarnCommand("AnimateIt2")]
        public void MovePlanchette2()
        {
            animIndex += 2;
            this.GetComponent<Animation>().clip = anim[animIndex];
            ouijaTime = true;
            planchette.GetComponent<Animation>().Play();
        }

        void startDialog()
        {
            FindObjectOfType<DialogueRunner>().StartDialogue();
        }
    }
}
