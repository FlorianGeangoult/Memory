using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    
    public Animator transition;
    public float TempsTransition = 1f;

    public void LanceJeuUltraEasy()
    {
        StartCoroutine(ChargeScene(SceneManager.GetActiveScene().buildIndex + 1));

    }
    public void LanceJeuEasy()
    {
        StartCoroutine(ChargeScene(SceneManager.GetActiveScene().buildIndex + 2));
    }
    public void LanceJeuNormal()
    {
        StartCoroutine(ChargeScene(SceneManager.GetActiveScene().buildIndex + 3));
    }
    public void LanceJeuHard()
    {
        StartCoroutine(ChargeScene(SceneManager.GetActiveScene().buildIndex + 4));
    }
    public void LanceJeuUltraHard()
    {
        StartCoroutine(ChargeScene(SceneManager.GetActiveScene().buildIndex + 5));
    }



    IEnumerator ChargeScene(int sceneIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(TempsTransition);

        SceneManager.LoadScene(sceneIndex);

    }

   

}
