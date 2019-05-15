using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Yarn.Unity
{


    public class ChangeScene : MonoBehaviour
    {
        public string nextScene;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        [YarnCommand("ChangeScene")]
        public void SwitchScene()
        {
            SceneManager.LoadScene(nextScene);
        }

    }

}
