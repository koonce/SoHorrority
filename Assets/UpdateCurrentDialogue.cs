using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Yarn.Unity
{
    public class UpdateCurrentDialogue : MonoBehaviour
    {

        FillUpCup fuc;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        [YarnCommand("UpdateCurrent")]
        public void ChangeCurrent()
        {
            this.GetComponent<FillUpCup>().current++;
            this.GetComponent<FillUpCup>().start = false;
        }


        [YarnCommand("NextScene")]
        public void ChangeScene()
        {
            SceneManager.LoadScene("Sunday");
        }
    }
}
