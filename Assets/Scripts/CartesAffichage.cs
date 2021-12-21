using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartesAffichage : MonoBehaviour
{
    public Carte carte;
    public CarteRandomizer jetcarte;
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




        }
    }

 
}
