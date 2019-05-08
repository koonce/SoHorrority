using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Yarn.Unity
{
    public class TextboxPosition : MonoBehaviour
    {
        public GameObject dialog;
        public GameObject text;
        public float xVar;
        public float yVar;

        public Vector3 pos;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        [YarnCommand("Speaking")]
        public void Talking()
        {
            Debug.Log("called Yarn command");
            Vector3 newPos = new Vector3(pos.x + xVar, pos.y + yVar, pos.z);

            dialog.transform.position = newPos;
            dialog.transform.parent = this.transform;

            //tmp.faceColor = c;
        }
    }
}
