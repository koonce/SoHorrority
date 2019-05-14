using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



namespace Yarn.Unity
{
    public class TextboxPosition : MonoBehaviour
    {
        public GameObject dialog;
        public GameObject text;
        public float xVar = 4f;
        public float yVar = .3f;
        public TextMeshPro cname;

        public GameObject dr;

        public Vector3 pos;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            pos = this.transform.position;
            if (dr.GetComponent<DialogueUI>().deciding)
            {
                cname.text = "";
            }
        }

        [YarnCommand("Speaking")]
        public void Talking()
        {
            cname.text = this.name;
            Debug.Log("called Yarn command");
            Vector3 newPos = new Vector3(pos.x + xVar, pos.y + yVar, dialog.transform.position.z);

            dialog.transform.position = newPos;
            dialog.transform.parent = this.transform;

            //tmp.faceColor = c;
        }
    }
}
