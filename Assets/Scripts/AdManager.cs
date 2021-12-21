using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    private string store_id = "3985091";

    public GameObject Bonus;
    public GameObject BonusVie;
    public GameObject BonusShow;
    public GameObject BonusDel;
    public GameObject CanvasReward;


    void Start()
    {
        Advertisement.Initialize(store_id, true);
    }




    public void AdMenu()
    {

        Debug.Log("tu appuies sur a bb");
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
            Bonus.SetActive(false);
            BonusVie.SetActive(true);
        }

    }

    public void AdLives()
    {

        Debug.Log("tu appuies sur a bb");
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            Bonus.SetActive(false);
            CanvasReward.SetActive(true);
            BonusVie.SetActive(true);

        }

    }



    public void AdShow()
    {

        Debug.Log("tu appuies sur a bb");
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            Bonus.SetActive(false);
            CanvasReward.SetActive(true);
            BonusShow.SetActive(true);

        }
    }


    public void AdDelete()
{

    Debug.Log("tu appuies sur a bb");
    if (Advertisement.IsReady("rewardedVideo"))
    {
        Advertisement.Show("rewardedVideo");
        Bonus.SetActive(false);
            CanvasReward.SetActive(true);
        BonusDel.SetActive(true);

    }

}
}
