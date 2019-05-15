using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicManagerScript : MonoBehaviour
{
    AudioSource ouijaMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Frinight")
        {
            if (ouijaMusic == null)
            {
                ouijaMusic = gameObject.AddComponent<AudioSource>();
            }
        }
    }
}
