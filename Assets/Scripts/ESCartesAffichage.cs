using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ESCartesAffichage : MonoBehaviour
{
    public Carte carte;
    public ESCarteRandomizer jetcarte;
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




        }
    }


}
