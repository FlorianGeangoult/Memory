﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UHDMemoryCheck : MonoBehaviour
{
   

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

    public List<Button> Boutons = new List<Button>(new Button[] { });
    public UHDCartesAffichage[] cul;

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
    public Animator Carte11;
    public Animator Carte12;
    public Animator Carte13;
    public Animator Carte14;
    public Animator Carte15;
    public Animator Carte16;
    public Animator Carte17;
    public Animator Carte18;
    public Animator Carte19;
    public Animator Carte20;
    public Animator Carte21;
    public Animator Carte22;
    public Animator Carte23;
    public Animator Carte24;
    public Animator Carte25;
    public Animator Carte26;
    public Animator Carte27;
    public Animator Carte28;
    public Animator Carte29;
    public Animator Carte30;
    public Animator Carte31;
    public Animator Carte32;
    public Animator Carte33;
    public Animator Carte34;
    public Animator Carte35;
    public Animator Carte36;
    public Animator Carte37;
    public Animator Carte38;
    public Animator Carte39;
    public Animator Carte40;
    public Animator Carte41;
    public Animator Carte42;
    public Animator Carte43;
    public Animator Carte44;
    public Animator Carte45;
    public Animator Carte46;
    public Animator Carte47;
    public Animator Carte48;
    public Animator Carte49;
    public Animator Carte50;
    public Animator Carte51;
    public Animator Carte52;
    public Animator Carte53;
    public Animator Carte54;
    public Animator Carte55;
    public Animator Carte56;
    public Animator Carte57;
    public Animator Carte58;
    public Animator Carte59;
    public Animator Carte60;
    public Animator Carte61;
    public Animator Carte62;
    public Animator Carte63;
    public Animator Carte64;
    public Animator Carte65;
    public Animator Carte66;
    public Animator Carte67;
    public Animator Carte68;
    public Animator Carte69;
    public Animator Carte70;
    public Animator Carte71;
    public Animator Carte72;
    public Animator Carte73;
    public Animator Carte74;
    public Animator Carte75;
    public Animator Carte76;
    public Animator Carte77;
    public Animator Carte78;
    public Animator Carte79;
    public Animator Carte80;


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
    public int vies = 40;
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

    public UHDCartesAffichage affiche;



    public UHDCarteRandomizer jetcarte;

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





    public void Carte1selec()
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

    public void Carte2selec()
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

    public void Carte11selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 11;

                Carte11.SetBool("clic", true);
                selecCheck();

            }
            else
            {
                CarteSelectionnee2 = 11;
                Carte11.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte12selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 12;
                Carte12.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 12;
                Carte12.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte13selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 13;
                Carte13.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 13;
                Carte13.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte14selec()
    {
        if (SlowDown == false)


        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 14;
                Carte14.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 14;
                Carte14.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte15selec()
    {

        if (SlowDown == false)
        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 15;
                Carte15.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 15;
                Carte15.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte16selec()
    {

        if (SlowDown == false)
        {


            if (Selection == false)
            {
                CarteSelectionnee1 = 16;
                Carte16.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 16;
                Carte16.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte17selec()
    {

        if (SlowDown == false)

        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 17;
                Carte17.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 17;
                Carte17.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte18selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 18;
                Carte18.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 18;
                Carte18.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte19selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 19;
                Carte19.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 19;
                Carte19.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte20selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 20;
                Carte20.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 20;
                Carte20.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte21selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 21;

                Carte21.SetBool("clic", true);
                selecCheck();

            }
            else
            {
                CarteSelectionnee2 = 21;
                Carte21.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte22selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 22;
                Carte22.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 22;
                Carte22.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte23selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 23;
                Carte23.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 23;
                Carte23.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte24selec()
    {
        if (SlowDown == false)


        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 24;
                Carte24.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 24;
                Carte24.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte25selec()
    {

        if (SlowDown == false)
        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 25;
                Carte25.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 25;
                Carte25.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte26selec()
    {

        if (SlowDown == false)
        {


            if (Selection == false)
            {
                CarteSelectionnee1 = 26;
                Carte26.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 26;
                Carte26.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte27selec()
    {

        if (SlowDown == false)

        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 27;
                Carte27.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 27;
                Carte27.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte28selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 28;
                Carte28.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 28;
                Carte28.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte29selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 29;
                Carte29.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 29;
                Carte29.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte30selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 30;
                Carte30.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 30;
                Carte30.SetBool("clic", true);
                Check();
            }
        }
    }
    public void Carte31selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 31;

                Carte31.SetBool("clic", true);
                selecCheck();

            }
            else
            {
                CarteSelectionnee2 = 31;
                Carte31.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte32selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 32;
                Carte32.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 32;
                Carte32.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte33selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 33;
                Carte33.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 33;
                Carte33.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte34selec()
    {
        if (SlowDown == false)


        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 34;
                Carte34.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 34;
                Carte34.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte35selec()
    {

        if (SlowDown == false)
        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 35;
                Carte35.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 35;
                Carte35.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte36selec()
    {

        if (SlowDown == false)
        {


            if (Selection == false)
            {
                CarteSelectionnee1 = 36;
                Carte36.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 36;
                Carte63.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte37selec()
    {

        if (SlowDown == false)

        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 37;
                Carte37.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 37;
                Carte37.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte38selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 38;
                Carte38.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 38;
                Carte38.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte39selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 39;
                Carte39.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 39;
                Carte39.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte40selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 40;
                Carte40.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 40;
                Carte40.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte41selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 41;

                Carte41.SetBool("clic", true);
                selecCheck();

            }
            else
            {
                CarteSelectionnee2 = 41;
                Carte41.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte42selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 42;
                Carte42.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 42;
                Carte42.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte43selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 43;
                Carte43.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 43;
                Carte43.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte44selec()
    {
        if (SlowDown == false)


        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 44;
                Carte44.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 44;
                Carte44.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte45selec()
    {

        if (SlowDown == false)
        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 45;
                Carte45.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 45;
                Carte45.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte46selec()
    {

        if (SlowDown == false)
        {


            if (Selection == false)
            {
                CarteSelectionnee1 = 46;
                Carte46.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 46;
                Carte46.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte47selec()
    {

        if (SlowDown == false)

        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 47;
                Carte47.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 47;
                Carte47.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte48selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 48;
                Carte48.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 48;
                Carte48.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte49selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 49;
                Carte49.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 49;
                Carte49.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte50selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 50;
                Carte50.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 50;
                Carte50.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte51selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 51;

                Carte51.SetBool("clic", true);
                selecCheck();

            }
            else
            {
                CarteSelectionnee2 = 51;
                Carte51.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte52selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 52;
                Carte52.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 52;
                Carte52.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte53selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 53;
                Carte53.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 53;
                Carte53.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte54selec()
    {
        if (SlowDown == false)


        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 54;
                Carte54.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 54;
                Carte54.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte55selec()
    {

        if (SlowDown == false)
        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 55;
                Carte55.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 55;
                Carte55.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte56selec()
    {

        if (SlowDown == false)
        {


            if (Selection == false)
            {
                CarteSelectionnee1 = 56;
                Carte56.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 56;
                Carte56.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte57selec()
    {

        if (SlowDown == false)

        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 57;
                Carte57.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 57;
                Carte57.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte58selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 58;
                Carte58.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 58;
                Carte58.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte59selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 59;
                Carte59.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 59;
                Carte59.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte60selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 60;
                Carte60.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 60;
                Carte60.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte61selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 61;

                Carte61.SetBool("clic", true);
                selecCheck();

            }
            else
            {
                CarteSelectionnee2 = 61;
                Carte61.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte62selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 62;
                Carte62.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 62;
                Carte62.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte63selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 63;
                Carte63.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 63;
                Carte63.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte64selec()
    {
        if (SlowDown == false)


        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 64;
                Carte64.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 64;
                Carte64.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte65selec()
    {

        if (SlowDown == false)
        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 65;
                Carte65.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 65;
                Carte65.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte66selec()
    {

        if (SlowDown == false)
        {


            if (Selection == false)
            {
                CarteSelectionnee1 = 66;
                Carte66.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 66;
                Carte66.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte67selec()
    {

        if (SlowDown == false)

        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 67;
                Carte67.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 67;
                Carte67.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte68selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 68;
                Carte68.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 68;
                Carte68.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte69selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 69;
                Carte69.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 69;
                Carte69.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte70selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 70;
                Carte70.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 70;
                Carte70.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte71selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 71;

                Carte71.SetBool("clic", true);
                selecCheck();

            }
            else
            {
                CarteSelectionnee2 = 71;
                Carte71.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte72selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 72;
                Carte72.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 72;
                Carte72.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte73selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 73;
                Carte73.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 73;
                Carte73.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte74selec()
    {
        if (SlowDown == false)


        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 74;
                Carte74.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 74;
                Carte74.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte75selec()
    {

        if (SlowDown == false)
        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 75;
                Carte75.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 75;
                Carte75.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte76selec()
    {

        if (SlowDown == false)
        {


            if (Selection == false)
            {
                CarteSelectionnee1 = 76;
                Carte76.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 76;
                Carte76.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte77selec()
    {

        if (SlowDown == false)

        {
            if (Selection == false)
            {
                CarteSelectionnee1 = 77;
                Carte77.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 77;
                Carte77.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte78selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 78;
                Carte78.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 78;
                Carte78.SetBool("clic", true);
                Check();
            }
        }
    }

    public void Carte79selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 79;
                Carte79.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 79;
                Carte79.SetBool("clic", true);
                Check();
            }

        }
    }

    public void Carte80selec()
    {
        if (SlowDown == false)

        {

            if (Selection == false)
            {
                CarteSelectionnee1 = 80;
                Carte80.SetBool("clic", true);
                selecCheck();
            }
            else
            {
                CarteSelectionnee2 = 80;
                Carte80.SetBool("clic", true);
                Check();
            }
        }
    }

    //Fait en sorte que si une carte est tirée alors la valeur 2 prendra la valeur de la prochaine carte cliquée
    public void selecCheck()
    {
        if (CarteSelectionnee1 != 0)
        {
            FindObjectOfType<Audio>().Play("Flip");
            Selection = true;
        }
    }

    // Vérifie si les cartes ont la même valeur
    public void Check()
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
                foreach (int numero in CartesInterdites) ;
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
            cartanim.SetBool("clic", false);
            cartanim.enabled = true;

        }
        
        yield return new WaitForSecondsRealtime(0.5f);

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
        if (paires == 40)
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

    public void RandomIA()
    {
        IACarte1 = Random.Range(1, 80);

    restart1:
        foreach (int x in CartesInterdites)
        {
            while (x == IACarte1)
            {
                IACarte1 = Random.Range(1, 80);
                Debug.Log("IACarte1 :" + IACarte1);
                goto restart1;
            }
        }

        IACarte2 = Random.Range(1, 80);
        while (IACarte2 == IACarte1)
        {
            IACarte2 = Random.Range(1, 80);
        }
    restart2:
        foreach (int x in CartesInterdites)
        {
            while (x == IACarte2 || IACarte2 == IACarte1)
            {
                IACarte2 = Random.Range(1, 80);
                Debug.Log("IACarte2 :" + IACarte2);
                goto restart2;
            }
        }


        Debug.Log("IACarte1 : " + IACarte1 + "IACarte2 : " + IACarte2);
        StartCoroutine(RetourneIA());


    }

    public void suppr2pairespart1()
    {
        if (paires < 39)
        {
            Cartesuppr1 = Random.Range(1, 80);

        restartsuppr1:
            foreach (int x in CartesInterdites)
            {
                while (x == Cartesuppr1)
                {
                    Cartesuppr1 = Random.Range(1, 80);
                    Debug.Log("Cartesuppr1 :" + Cartesuppr1);
                    goto restartsuppr1;
                }
            }

            valeursuppr1 = jetcarte.valeurcartes[Cartesuppr1 - 1];
            Debug.Log(valeursuppr1);
            foreach (UHDCartesAffichage c in cul)
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
            case 11:
                Carte11selec();
                break;
            case 12:
                Carte12selec();
                break;
            case 13:
                Carte13selec();
                break;
            case 14:
                Carte14selec();
                break;
            case 15:
                Carte15selec();
                break;
            case 16:
                Carte16selec();
                break;
            case 17:
                Carte17selec();
                break;
            case 18:
                Carte18selec();
                break;
            case 19:
                Carte19selec();
                break;
            case 20:
                Carte20selec();
                break;
            case 21:
                Carte21selec();
                break;
            case 22:
                Carte22selec();
                break;
            case 23:
                Carte23selec();
                break;
            case 24:
                Carte24selec();
                break;
            case 25:
                Carte25selec();
                break;
            case 26:
                Carte26selec();
                break;
            case 27:
                Carte27selec();
                break;
            case 28:
                Carte28selec();
                break;
            case 29:
                Carte29selec();
                break;
            case 30:
                Carte30selec();
                break;
            case 31:
                Carte31selec();
                break;
            case 32:
                Carte22selec();
                break;
            case 33:
                Carte33selec();
                break;
            case 34:
                Carte34selec();
                break;
            case 35:
                Carte35selec();
                break;
            case 36:
                Carte36selec();
                break;
            case 37:
                Carte37selec();
                break;
            case 38:
                Carte38selec();
                break;
            case 39:
                Carte39selec();
                break;
            case 40:
                Carte40selec();
                break;
            case 41:
                Carte41selec();
                break;
            case 42:
                Carte42selec();
                break;
            case 43:
                Carte43selec();
                break;
            case 44:
                Carte44selec();
                break;
            case 45:
                Carte45selec();
                break;
            case 46:
                Carte46selec();
                break;
            case 47:
                Carte47selec();
                break;
            case 48:
                Carte48selec();
                break;
            case 49:
                Carte49selec();
                break;
            case 50:
                Carte50selec();
                break;
            case 51:
                Carte51selec();
                break;
            case 52:
                Carte52selec();
                break;
            case 53:
                Carte53selec();
                break;
            case 54:
                Carte54selec();
                break;
            case 55:
                Carte55selec();
                break;
            case 56:
                Carte56selec();
                break;
            case 57:
                Carte57selec();
                break;
            case 58:
                Carte58selec();
                break;
            case 59:
                Carte59selec();
                break;
            case 60:
                Carte60selec();
                break;
            case 61:
                Carte61selec();
                break;
            case 62:
                Carte62selec();
                break;
            case 63:
                Carte63selec();
                break;
            case 64:
                Carte64selec();
                break;
            case 65:
                Carte65selec();
                break;
            case 66:
                Carte66selec();
                break;
            case 67:
                Carte67selec();
                break;
            case 68:
                Carte68selec();
                break;
            case 69:
                Carte69selec();
                break;
            case 70:
                Carte70selec();
                break;
            case 71:
                Carte71selec();
                break;
            case 72:
                Carte72selec();
                break;
            case 73:
                Carte73selec();
                break;
            case 74:
                Carte74selec();
                break;
            case 75:
                Carte75selec();
                break;
            case 76:
                Carte76selec();
                break;
            case 77:
                Carte77selec();
                break;
            case 78:
                Carte78selec();
                break;
            case 79:
                Carte79selec();
                break;
            case 80:
                Carte80selec();
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
            case 11:
                Carte11selec();
                break;
            case 12:
                Carte12selec();
                break;
            case 13:
                Carte13selec();
                break;
            case 14:
                Carte14selec();
                break;
            case 15:
                Carte15selec();
                break;
            case 16:
                Carte16selec();
                break;
            case 17:
                Carte17selec();
                break;
            case 18:
                Carte18selec();
                break;
            case 19:
                Carte19selec();
                break;
            case 20:
                Carte20selec();
                break;
            case 21:
                Carte21selec();
                break;
            case 22:
                Carte22selec();
                break;
            case 23:
                Carte23selec();
                break;
            case 24:
                Carte24selec();
                break;
            case 25:
                Carte25selec();
                break;
            case 26:
                Carte26selec();
                break;
            case 27:
                Carte27selec();
                break;
            case 28:
                Carte28selec();
                break;
            case 29:
                Carte29selec();
                break;
            case 30:
                Carte30selec();
                break;
            case 31:
                Carte31selec();
                break;
            case 32:
                Carte22selec();
                break;
            case 33:
                Carte33selec();
                break;
            case 34:
                Carte34selec();
                break;
            case 35:
                Carte35selec();
                break;
            case 36:
                Carte36selec();
                break;
            case 37:
                Carte37selec();
                break;
            case 38:
                Carte38selec();
                break;
            case 39:
                Carte39selec();
                break;
            case 40:
                Carte40selec();
                break;
            case 41:
                Carte41selec();
                break;
            case 42:
                Carte42selec();
                break;
            case 43:
                Carte43selec();
                break;
            case 44:
                Carte44selec();
                break;
            case 45:
                Carte45selec();
                break;
            case 46:
                Carte46selec();
                break;
            case 47:
                Carte47selec();
                break;
            case 48:
                Carte48selec();
                break;
            case 49:
                Carte49selec();
                break;
            case 50:
                Carte50selec();
                break;
            case 51:
                Carte51selec();
                break;
            case 52:
                Carte52selec();
                break;
            case 53:
                Carte53selec();
                break;
            case 54:
                Carte54selec();
                break;
            case 55:
                Carte55selec();
                break;
            case 56:
                Carte56selec();
                break;
            case 57:
                Carte57selec();
                break;
            case 58:
                Carte58selec();
                break;
            case 59:
                Carte59selec();
                break;
            case 60:
                Carte60selec();
                break;
            case 61:
                Carte61selec();
                break;
            case 62:
                Carte62selec();
                break;
            case 63:
                Carte63selec();
                break;
            case 64:
                Carte64selec();
                break;
            case 65:
                Carte65selec();
                break;
            case 66:
                Carte66selec();
                break;
            case 67:
                Carte67selec();
                break;
            case 68:
                Carte68selec();
                break;
            case 69:
                Carte69selec();
                break;
            case 70:
                Carte70selec();
                break;
            case 71:
                Carte71selec();
                break;
            case 72:
                Carte72selec();
                break;
            case 73:
                Carte73selec();
                break;
            case 74:
                Carte74selec();
                break;
            case 75:
                Carte75selec();
                break;
            case 76:
                Carte76selec();
                break;
            case 77:
                Carte77selec();
                break;
            case 78:
                Carte78selec();
                break;
            case 79:
                Carte79selec();
                break;
            case 80:
                Carte80selec();
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
