using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MusicManagerScript : MonoBehaviour
{
    AudioSource mainAudioSource;
    AudioSource ouijaMusic;
    public GameObject speech;
    public AudioClip song;
    bool ouijaBool = false;
    int volumeBool = 0;
    // Start is called before the first frame update
    void Start()
    {
        mainAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Frinight")
        {
            if (ouijaMusic == null)
            {
                ouijaMusic = gameObject.AddComponent<AudioSource>();
                ouijaMusic.clip = song;
                
            }
            if(speech.GetComponent<TextMeshPro>().text== "I will summon your sister.")
            {
                ouijaBool = true;
            }
        }
        if (ouijaBool)
        {

        }
    }
}
