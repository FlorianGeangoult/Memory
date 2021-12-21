using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsScript : MonoBehaviour
{
    public bool BGMMute;
    public bool SFXMute;
    public bool SONMute;

    public bool ToggleSON;
    public bool ToggleBGM;
    public bool ToggleSFX;


    public bool SFXmute;
    public bool SONmute;

    public OptionsScript instance;

    public float Memvolume;
    public float MemvolumeBGM;
    public float MemvolumeSFX;

    public Toggle togMuteSon;
    public Toggle togMuteBGM;
    public Toggle togMuteSFX;

    public AudioMixer audioMixer;
    private Audio audioz;
    private Joueurs joueurs;

    public Dropdown Reschoix;

    void Start()
    {
        joueurs = GameObject.Find("JoueursScript").GetComponent<Joueurs>();
        audioz = GameObject.Find("Audio").GetComponent<Audio>();
        ToggleSON = joueurs.ToggleSON;
        ToggleBGM = joueurs.ToggleBGM;
        ToggleSFX = joueurs.ToggleSFX;
        if (ToggleSON == true)
        {
            togMuteSon.isOn = true;
        }
        else
        {
            if (ToggleSON == false)
            {

                togMuteSon.isOn = false;
            }
        }

        if (ToggleBGM == true)
        {
     
            togMuteBGM.isOn = true;
        }
        else
        {
            if (ToggleBGM == false)
            {
               
                togMuteBGM.isOn = false;
            }
        }

        if (ToggleSFX == true)
        {
            togMuteSFX.isOn = true;
        }
        else
        {
            if (ToggleSFX == false)
            {

                togMuteSFX.isOn = false;
            }
        }
    }

    void Awake()
    {
       

    }

   

    public void DefSon(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        Memvolume = volume;
    }

    public void DefSonBGM(float volume)
    {
        audioMixer.SetFloat("volumeBGM", volume);
        MemvolumeBGM = volume;
    }

    public void DefSonSFX(float volume)
    {
        audioMixer.SetFloat("volumeSFX", volume);
        MemvolumeSFX = volume;
    }

    public void MuteSON(bool SONMute)
    {



        if (SONMute == true)
        {
            audioMixer.SetFloat("volume", Memvolume);
            joueurs.ToggleSON = true;
        }
        else
        {
            if (SONMute == false)
            {

                audioMixer.SetFloat("volume", -80.0f);
                joueurs.ToggleSON = false;
            }
        }
    }

   

    public void MuteBGM(bool BGMMute)
    {
        if (BGMMute == true)
        {
            audioz.MuteBGM(BGMMute);
            joueurs.ToggleBGM = true;
            
        }
        else
        {
            if (BGMMute == false)
            {

                audioz.MuteBGM(BGMMute);
                joueurs.ToggleBGM = false;
              
            }
        }

    }


    public void MuteSFX(bool SFXMute)
    {
        if (SFXMute == true)
        {
            audioz.MuteSFX(SFXMute);
            joueurs.ToggleSFX = true;
            
        }
        else
        {
            if (SFXMute == false)
            {

                audioz.MuteSFX(SFXMute);
                joueurs.ToggleSFX = false;
                
            }
        }
    }

    


    public void DefQualité(int IndicQualité)
    {
        QualitySettings.SetQualityLevel(IndicQualité);
    }

    public void Quitter()
    {
        Application.Quit();
    }

}