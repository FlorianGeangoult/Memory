using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Joueurs : MonoBehaviour
{

    public static Joueurs Instance;

    public Button solobouton;
    public GameObject ChoixJou;
    public GameObject ChoixDiff;
    public Animator choixjou;
    public Animator choixdiff;
    public Animator Joueursmenu;
    public Animator Diffmenu;
    public bool solobool;
    public bool soloiabool;
    public bool multijoueurbool;
    public bool ToggleSON;
    public bool ToggleBGM;
    public bool ToggleSFX;

    void Awake()
    {
        ToggleSON = true;
        ToggleBGM = true;
        ToggleSFX = true;
        solobool = true;
        solobouton.interactable = false;

        DontDestroyOnLoad(this);
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance.gameObject);
        }
    }

 

    

    public void solo()
    {
        solobool = true;
        soloiabool = false;
        multijoueurbool = false;
    }

    public void soloia()
    {
        solobool = false;
        soloiabool = true;
        multijoueurbool = false;
    }

    public void multijoueur()
    {
        solobool = false;
        soloiabool = false;
        multijoueurbool = true;
    }

    public void JoueursAnimDecale()
    {
        ChoixJou.SetActive(false);
        ChoixJou.SetActive(true);
        Joueursmenu.SetBool("décale", true);

    }

    public void JoueursAnimDecalePas()
    {
        Joueursmenu.SetBool("décale", false);
        choixjou.SetBool("disparition", true);
    }

    public void DiffAnimDecale()
    {
        ChoixDiff.SetActive(false);
        ChoixDiff.SetActive(true);
        Diffmenu.SetBool("dec", true);

    }

    public void DiffAnimDecalePas()
    {
        Diffmenu.SetBool("dec", false);
        choixdiff.SetBool("disp", true);
    }
}
