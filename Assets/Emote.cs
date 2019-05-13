using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

namespace Yarn.Unity
{
    public class Emote : MonoBehaviour
    {
        public Sprite sad, happy, normal;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        [YarnCommand("Sad")]
        public void SadFace()
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sad;
        }

        [YarnCommand("Happy")]
        public void HappyFace()
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = happy;
        }

        [YarnCommand("Normal")]
        public void NormalFace()
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = normal;
        }
    }
}

