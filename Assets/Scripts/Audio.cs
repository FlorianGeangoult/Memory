using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public bool BGMMute;
    public bool SFXMute;

    public static Audio instance;

   

    public OptionsScript options;

    public Sound[] sounds;
   

    void Awake()
    {

        

            if (instance == null)
                instance = this;
            else
            {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);
            foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.outputAudioMixerGroup = s.group;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.mute = s.mute;
            s.source.loop = s.loop;
        }
    }


    void Start()
    {
        Play("MusiqueMenu");
    }


    


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("La musique" + name + "n'a pas été trouvée");
            return;
        }


        s.source.Play();
    }

    public void MuteBGM(bool BGMMute)
    {
        Sound s = Array.Find(sounds, sound => sound.name == "MusiqueMenu");
        if (s == null)
        {
            Debug.Log("La musique musique menu n'a pas été trouvée");
            return;
        }


        s.source.mute = !BGMMute;
    }

    public void MuteSFX(bool SFXMute)
    {
        Sound s = Array.Find(sounds, sound => sound.name == "Flip");
        if (s == null)
        {
            Debug.Log("La musique musique menu n'a pas été trouvée");
            return;
        }


        s.source.mute = !SFXMute;
    }

    



    public void Pause(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("La musique" + name + "n'a pas été trouvée");
            return;
        }


        s.source.Pause();
    }



    public void StopPlaying(string sound)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }



        s.source.Stop();
    }

}
