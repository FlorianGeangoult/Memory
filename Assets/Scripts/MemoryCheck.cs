﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryCheck : MonoBehaviour
{
  

    public List<Button> Boutons = new List<Button>(new Button[] { });
    public CartesAffichage[] cul;

    public GameObject Perdu;
    public GameObject Gagné;
    public GameObject VictoireJ1;
    public GameObject VictoireJ2;
    public GameObject VictoireIA;
    public GameObject Egalité;

    public GameObject Vies;
    public GameObject Points;
    public GameObject PointsJ1;
    public GameObject PointsJ2;
    public GameObject PointsIA;
    public GameObject TourJ1;
    public GameObject TourJ2;
    public GameObject TourIA;

    public GameObject Bonus;

    public List<GameObject> Cartes = new List<GameObject>(new GameObject[] { });
    public List<Animator> Cartesanim = new List<Animator>(new Animator[] { });

    public Animator Carte1;
    public Animator Carte2;
    public Animator Carte3;
    public Animator Carte4;
    public Animator Carte5;
    public Animator Carte6;
    public Animator Carte7;
    public Animator Carte8;
    public Animator Carte9;
    public Animator Carte10;

    private Joueurs joueurs;

    public List<int> CartesInterdites = new List<int>(new int[] { });

    public int CarteSelectionnee1;
    public int CarteSelectionnee2;
    public int Cartesuppr1;
    public int valeursuppr1;
    public int valeur1;
    public int valeur2;
    public int IACarte1;
    public int IACarte2;
    public int points;
    public int pointsJ1;
    public int pointsJ2;
    public int pointsIA;
    public int vies = 5;
    public int paires;

    public bool SlowDown;
    public bool SlowDownIA;

    public bool tourJ1;
    public bool tourJ2;
    public bool tourIA;

    public Text Affichepoints;
    public Text AffichepointsJ1;
    public Text AffichepointsJ2;
    public Text AffichepointsIA;
    public Text Affichevies;

    public CartesAffichage affiche;

    public CarteRandomizer jetcarte;

    public bool Selection;
    public bool Bonchoix;

    void Start()
    {

        joueurs = GameObject.Find("JoueursScript").GetComponent<Joueurs>();




        if (joueurs.multijoueurbool == true)
        {
            Vies.SetActive(false);
            Points.SetActive(false);
            PointsIA.SetActive(false);
            PointsJ1.SetActive(true);
            PointsJ2.SetActive(true);
            TourJ1.SetActive(true);
            Bonus.SetActive(false);
            tourJ1 = true;
        }

        if (joueurs.solobool == true)
        {
            Vies.SetActive(true);
            Points.SetActive(true);
            PointsIA.SetActive(false);
            PointsJ1.SetActive(false);
            PointsJ2.SetActive(false);
            Bonus.SetActive(true); ;

        }

        if (joueurs.soloiabool == true)
        {
            Vies.SetActive(false);
            Points.SetActive(false);
            PointsIA.SetActive(true);
            PointsJ1.SetActive(true);
            PointsJ2.SetActive(false);
            TourJ1.SetActive(true);
            Bonus.SetActive(false);
            tourJ1 = true;
        }


    }



   


    public void Carte1selec ()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 1;
                Carte1.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 1;
                Carte1.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte2selec ()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 2;
                Carte2.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 2;
                Carte2.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte3selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 3;
                Carte3.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 3;
                Carte3.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte4selec()
    {
        if (SlowDown == false)


        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 4;
                Carte4.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 4;
                Carte4.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte5selec()
    {

        if (SlowDown == false)
        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 5;
                Carte5.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 5;
                Carte5.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte6selec()
    {

        if (SlowDown == false)
        {


            if (Selection == false)
            {
                CarteSelectionnee1 = 6;
                Carte6.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 6;
                Carte6.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte7selec()
    {

        if (SlowDown == false)

        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 7;
                Carte7.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 7;
                Carte7.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte8selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 8;
                Carte8.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 8;
                Carte8.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte9selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 9;
                Carte9.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 9;
                Carte9.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte10selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 10;
                Carte10.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 10;
                Carte10.SetBool("clic", true);
                Check();
            }
        }
    }

    //Fait en sorte que si une carte est tirée alors la valeur 2 prendra la valeur de la prochaine carte cliquée
    public void selecCheck()
    {
        FindObjectOfType<Audio>().Play("Flip");

        if (CarteSelectionnee1 != 0)
        {
           
            Selection = true;
        }
    }


    public void Update()
    {
        if (tourIA)
        {
            SlowDownIA = true;
        }
        else
        {
            SlowDownIA = false;
        }

        if (SlowDownIA)
        {
            foreach (Button Bouton in Boutons)
            {
                Bouton.interactable = false;
            }
        }
        else
        {
            foreach (Button Bouton in Boutons)
            {
                Bouton.interactable = true;
            }
        }
    }


    // Vérifie si les cartes ont la même valeur
    public void Check ()
    {
        FindObjectOfType<Audio>().Play("Flip");
        Selection = false;
        valeur1 = jetcarte.valeurcartes[CarteSelectionnee1 - 1];
        valeur2 = jetcarte.valeurcartes[CarteSelectionnee2 - 1];
        Debug.Log("valeur 1 :" + valeur1 + "valeur 2:" + valeur2);
       
        if (CarteSelectionnee1 == CarteSelectionnee2)

        {
            valeur2 = 0;
            Selection = true;
        }

        else
        {
            
            

            if (valeur1 == valeur2)

            {
                Checkbon();
                CartesInterdites.Add(CarteSelectionnee1);
                CartesInterdites.Add(CarteSelectionnee2);
                Debug.Log(CartesInterdites);
                foreach (int numero in CartesInterdites)
                {
                    Debug.Log("Carte interdite :" + numero.ToString());
                }

            }
            else
        
            {
                Checkmauvais();
            }

        }
    }

    IEnumerator pauseretournevrai()
    {
        SlowDown = true;

        yield return new WaitForSeconds(2);


        Cartes[CarteSelectionnee1 - 1].SetActive(false);
        Cartes[CarteSelectionnee2 - 1].SetActive(false);


        SlowDown = false;
        paires += 1;
        CartesCheck();
    }


    IEnumerator pauseretournefaux()
    {
        SlowDown = true;
        
        yield return new WaitForSeconds(2);
        foreach (Animator cartanim in Cartesanim)
        {
            Debug.Log("c'est quoi ce souk");
            cartanim.SetBool("clic", false);
            cartanim.enabled = true;

        }
        yield return new WaitForSecondsRealtime(0.01f);
        SlowDown = false;

        VieCheck();

    }

    public void Checkbon()
    {

        Bonchoix = true;
        Debug.Log("bravo c'est bon");

        if (joueurs.solobool == true)

        {
            points += 1;
            AfficherPoints();
            Affichepoints.text = AfficherPoints();

        }

        if (joueurs.multijoueurbool == true)

        {
            if (tourJ1 == true)

            {
                pointsJ1 += 1;
                AfficherPointsJ1();
                AffichepointsJ1.text = AfficherPointsJ1();

            }

            if (tourJ2 == true)

            {
                pointsJ2 += 1;
                AfficherPointsJ2();
                AffichepointsJ2.text = AfficherPointsJ2();

            }


        }

        if (joueurs.soloiabool == true)

        {
            if (tourJ1 == true)

            {
                pointsJ1 += 1;
                AfficherPointsJ1();
                AffichepointsJ1.text = AfficherPointsJ1();

            }

            if (tourIA == true)

            {
                pointsIA += 1;
                AfficherPointsIA();
                AffichepointsIA.text = AfficherPointsIA();
                RandomIA();

            }

        }



        StartCoroutine(pauseretournevrai());




    }

    public string AfficherPoints()
    {
        return "Points :" + points + " ";
    }

    public string AfficherPointsJ1()
    {
        return "P1 Points :" + pointsJ1 + " ";
    }

    public string AfficherPointsJ2()
    {
        return "P2 Points :" + pointsJ2 + " ";
    }
    public string AfficherPointsIA()
    {
        return "AI Points :" + pointsIA + " ";
    }


    public void Checkmauvais()
        {

        Bonchoix = false;
        Debug.Log("nul à chier");

        if (joueurs.solobool == true)
        {

            vies -= 1;


            AfficherVies();
            Affichevies.text = AfficherVies();

        }


        if (joueurs.multijoueurbool == true)

        {


            if (tourJ1 == true)
            {

                tourJ1 = false;
                tourJ2 = true;
                TourJ2.SetActive(true);
                TourJ1.SetActive(false);
                Debug.Log("pd");
            }
            else
            {
                tourJ2 = false;
                tourJ1 = true;
                TourJ1.SetActive(true);
                TourJ2.SetActive(false);
            }
        }
                if (joueurs.soloiabool == true)

                {


                    if (tourJ1 == true)
                    {
                        SlowDown = true;
                        tourJ1 = false;
                        tourIA = true;
                        TourIA.SetActive(true);
                        TourJ1.SetActive(false);
                        RandomIA();
                        Debug.Log("pd");
                    }
                    else
                    {
                        tourIA = false;
                        tourJ1 = true;
                        TourJ1.SetActive(true);
                        TourIA.SetActive(false);
                    }
                }


                StartCoroutine(pauseretournefaux());


            }

    public string AfficherVies()
    {
        return "Lives :" + vies + " ";
    }

    public void VieCheck()
    {
        if (vies == 0)
        {
            Perdu.SetActive(true);
        }

    }

    public void CartesCheck()
    {
        {
            if (paires == 5)
            {
                if (joueurs.solobool == true)
                {
                    Gagné.SetActive(true);
                }

                if (joueurs.multijoueurbool == true)
                {
                    if (pointsJ1 > pointsJ2)
                    {
                        VictoireJ1.SetActive(true);
                    }
                    if (pointsJ2 > pointsJ1)
                    {
                        VictoireJ2.SetActive(true);
                    }
                    if (pointsJ2 == pointsJ1)
                    {
                        Egalité.SetActive(true);
                    }

                }
                if (joueurs.soloiabool == true)
                {
                    if (pointsJ1 > pointsIA)
                    {
                        VictoireJ1.SetActive(true);
                    }
                    if (pointsIA > pointsJ1)
                    {
                        VictoireIA.SetActive(true);
                    }
                    if (pointsIA == pointsJ1)
                    {
                        Egalité.SetActive(true);
                    }

                }
            }

        }

    }
    public void RandomIA()
    {
        IACarte1 = Random.Range(1, 10);

            restart1:
            foreach (int x in CartesInterdites)
            {
                while (x == IACarte1)
                {
                    IACarte1 = Random.Range(1, 10);
                    Debug.Log("IACarte1 :" + IACarte1);
                goto restart1;
                }
            }
        
        IACarte2 = Random.Range(1, 10);
        while (IACarte2 == IACarte1)
        {
            IACarte2 = Random.Range(1, 10);
        }
        restart2:
            foreach (int x in CartesInterdites)
            {
                while (x == IACarte2 || IACarte2 == IACarte1)
                {
                    IACarte2 = Random.Range(1, 10);
                    Debug.Log("IACarte2 :" + IACarte2);
                goto restart2;
                }
            }
        

        Debug.Log("IACarte1 : " + IACarte1 + "IACarte2 : " + IACarte2);
        StartCoroutine(RetourneIA());

    }

    public void suppr2pairespart1()
    {
        if (paires < 4)
        {
            Cartesuppr1 = Random.Range(1, 10);

        restartsuppr1:
            foreach (int x in CartesInterdites)
            {
                while (x == Cartesuppr1)
                {
                    Cartesuppr1 = Random.Range(1, 10);
                    Debug.Log("Cartesuppr1 :" + Cartesuppr1);
                    goto restartsuppr1;
                }
            }

            valeursuppr1 = jetcarte.valeurcartes[Cartesuppr1 - 1];
            Debug.Log(valeursuppr1);
            foreach (CartesAffichage c in cul)
            {

                if (c.valeurcarte == valeursuppr1)
                {
                    Debug.Log("sex" + c.valeurcarte + "num" + c.Numcarte);
                    Cartesuppr1 = c.Numcarte + 1;
                    CartesInterdites.Add(Cartesuppr1);
                    
                    
                    Supprpaires1();
                }

            }
            paires += 1;
            
            points += 1;
            AfficherPoints();
            Affichepoints.text = AfficherPoints();
        }

    }

    public void Supprpaires1()
    {
        Cartes[Cartesuppr1 - 1].SetActive(false);

    }


    IEnumerator RetourneIA()
    {
        SlowDown = true;
        yield return new WaitForSecondsRealtime(4);
        switch (IACarte1)
        {
            case 1:
                Carte1selec();
                break;
            case 2:
                Carte2selec();
                break;
            case 3:
                Carte3selec();
                break;
            case 4:
                Carte4selec();
                break;
            case 5:
                Carte5selec();
                break;
            case 6:
                Carte6selec();
                break;
            case 7:
                Carte7selec();
                break;
            case 8:
                Carte8selec();
                break;
            case 9:
                Carte9selec();
                break;
            case 10:
                Carte10selec();
                break;
        }

        yield return new WaitForSecondsRealtime(1);

        switch (IACarte2)
        {
            case 1:
                Carte1selec();
                break;
            case 2:
                Carte2selec();
                break;
            case 3:
                Carte3selec();
                break;
            case 4:
                Carte4selec();
                break;
            case 5:
                Carte5selec();
                break;
            case 6:
                Carte6selec();
                break;
            case 7:
                Carte7selec();
                break;
            case 8:
                Carte8selec();
                break;
            case 9:
                Carte9selec();
                break;
            case 10:
                Carte10selec();
                break;
        }
    }
    public void rajoutevies()
    {
        vies = vies + 5;
        AfficherVies();
        Affichevies.text = AfficherVies();
    }

    public void montrecartes()
    {
        FindObjectOfType<Audio>().Play("Flip");
        StartCoroutine(Retournecartes());
    }

    IEnumerator Retournecartes()
    {
        SlowDown = true;
        foreach (Animator cartanim in Cartesanim)
        {
            cartanim.SetBool("clic", true);

        }

        yield return new WaitForSeconds(3);
        foreach (Animator cartanim in Cartesanim)
        {
            cartanim.SetBool("clic", false);
            cartanim.enabled = true;
        }

        yield return new WaitForSecondsRealtime(0.5f);

        SlowDown = false;

    }
}
