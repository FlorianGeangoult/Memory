using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDCarteRandomizer : MonoBehaviour
{
    // Crée le tableau des valeurs à mélanger et le tableau des valeurs de cartes après le mélange

    public int[] TableauInit = new int[40] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17, 18, 18, 19, 19, 20, 20 };
    public int[] valeurcartes = new int[40];


    void Start()
    {
        Mélangeur();
    }


    // Mélange les valeurs du tableau et les attribue au tableau des valeurs de cartes
    public void Mélangeur()
    {


        for (int i = 0; i < TableauInit.Length; i++)
        {
            int tmp = TableauInit[i];
            int r = Random.Range(i, TableauInit.Length);
            TableauInit[i] = TableauInit[r];
            TableauInit[r] = tmp;
           

        }
        for (int i = 0; i < TableauInit.Length; i++)
        {
            valeurcartes[i] = TableauInit[i];

        }

      

    }

}