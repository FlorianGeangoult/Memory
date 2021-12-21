using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NRCartesAffichage : MonoBehaviour
{
    public Carte carte;
    public NRCarteRandomizer jetcarte;
    public Image ApparenceImage;
    public int Numcarte;

    public int valeurcarte;


    // Start is called before the first frame update
    public void Update()
    {

        

        valeurcarte = jetcarte.valeurcartes[Numcarte];



        switch (valeurcarte)
        {
            case 1:

                ApparenceImage.sprite = carte.coeur1;
                break;

            case 2:
                ApparenceImage.sprite = carte.coeur2;
                break;

            case 3:
                ApparenceImage.sprite = carte.coeur3;
                break;
            case 4:
                ApparenceImage.sprite = carte.coeur4;
                break;
            case 5:
                ApparenceImage.sprite = carte.coeur5;
                break;
            case 6:
                ApparenceImage.sprite = carte.trefle1;
                break;

            case 7:
                ApparenceImage.sprite = carte.trefle2;
                break;

            case 8:
                ApparenceImage.sprite = carte.trefle3;
                break;
            case 9:
                ApparenceImage.sprite = carte.trefle4;
                break;
            case 10:
                ApparenceImage.sprite = carte.trefle5;
                break;
            case 11:
                ApparenceImage.sprite = carte.kro1;
                break;

            case 12:
                ApparenceImage.sprite = carte.kro2;
                break;

            case 13:
                ApparenceImage.sprite = carte.kro3;
                break;
            case 14:
                ApparenceImage.sprite = carte.kro4;
                break;
            case 15:
                ApparenceImage.sprite = carte.kro5;
                break;



        }
    }


}
