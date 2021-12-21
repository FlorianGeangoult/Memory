using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UHDCartesAffichage : MonoBehaviour
{
    public Carte carte;
    public UHDCarteRandomizer jetcarte;
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
            case 16:
                ApparenceImage.sprite = carte.pik1;
                break;

            case 17:
                ApparenceImage.sprite = carte.pik2;
                break;

            case 18:
                ApparenceImage.sprite = carte.pik3;
                break;
            case 19:
                ApparenceImage.sprite = carte.pik4;
                break;
            case 20:
                ApparenceImage.sprite = carte.pik5;
                break;

            case 21:

                ApparenceImage.sprite = carte.coeur6;
                break;

            case 22:
                ApparenceImage.sprite = carte.coeur7;
                break;

            case 23:
                ApparenceImage.sprite = carte.coeur8;
                break;
            case 24:
                ApparenceImage.sprite = carte.coeur9;
                break;
            case 25:
                ApparenceImage.sprite = carte.coeur10;
                break;
            case 26:
                ApparenceImage.sprite = carte.trefle6;
                break;

            case 27:
                ApparenceImage.sprite = carte.trefle7;
                break;

            case 28:
                ApparenceImage.sprite = carte.trefle8;
                break;
            case 29:
                ApparenceImage.sprite = carte.trefle9;
                break;
            case 30:
                ApparenceImage.sprite = carte.trefle10;
                break;
            case 31:
                ApparenceImage.sprite = carte.kro6;
                break;

            case 32:
                ApparenceImage.sprite = carte.kro7;
                break;

            case 33:
                ApparenceImage.sprite = carte.kro8;
                break;
            case 34:
                ApparenceImage.sprite = carte.kro9;
                break;
            case 35:
                ApparenceImage.sprite = carte.kro10;
                break;
            case 36:
                ApparenceImage.sprite = carte.pik6;
                break;

            case 37:
                ApparenceImage.sprite = carte.pik7;
                break;

            case 38:
                ApparenceImage.sprite = carte.pik8;
                break;
            case 39:
                ApparenceImage.sprite = carte.pik9;
                break;
            case 40:
                ApparenceImage.sprite = carte.pik10;
                break;
        }
    }

}
