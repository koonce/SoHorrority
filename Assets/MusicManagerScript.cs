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
    public AudioClip song2;
    bool ouijaBool = false;
    public float volumeBool = 0;
    GameObject musicPlayer;
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
                musicPlayer = new GameObject("ok");
                ouijaMusic = musicPlayer.gameObject.AddComponent<AudioSource>();
                ouijaMusic.clip = song;
            }
            if(speech.GetComponent<TextMeshPro>().text== "I will summon your sister." && !ouijaBool)
            {
                ouijaBool = true;
                ouijaMusic.Play();
            }
        }
        if (ouijaBool)
        {
            if (volumeBool < 1) { volumeBool += 0.0001f; }
            mainAudioSource.volume = 1 - volumeBool;
            ouijaMusic.volume = volumeBool + 0.5f;
            
            if (ouijaMusic.isPlaying == false)
            {
                ouijaMusic.clip = song2;
                ouijaMusic.Play();
                ouijaMusic.loop = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "Sunnight")
        {
            mainAudioSource.volume = volumeBool;
            if (speech.GetComponent<TextMeshPro>().text == "I feel good." && !ouijaBool)
            {
                ouijaBool = true;
            }
            if (ouijaBool)
            {
                if (volumeBool < 1) { volumeBool += 0.0001f; }
            }
            if (speech.GetComponent<TextMeshPro>().text == "Now, close your eyes." && ouijaBool)
            {
                mainAudioSource.clip = song;
                mainAudioSource.Play();
                mainAudioSource.loop = false;
                ouijaBool = false;
            }
        }
    }
}
