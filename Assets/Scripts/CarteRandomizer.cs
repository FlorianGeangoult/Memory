using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarteRandomizer : MonoBehaviour
{
    // Crée le tableau des valeurs à mélanger et le tableau des valeurs de cartes après le mélange

    public int[] TableauInit = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
    public int[] valeurcartes = new int[10];


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
