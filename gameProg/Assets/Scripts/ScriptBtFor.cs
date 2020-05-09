using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtFor: MonoBehaviour
{
    public int nBBouclePour;
    public GameObject btFinPour, goDrowdown;
    public Dropdown choixIter;
    public bool drowdownActif;


    public ArrayList listeIteration = new ArrayList();
    public ArrayList listeIterationEnCour = new ArrayList();
    public ArrayList listeCoordonne = new ArrayList();
    public int nbBoucleOuverte;
    public int nbBoucleFini;
    public bool boolBoucleFin;
   

    void Start()
    {
        drowdownActif = false;
        nBBouclePour = 0;
        nbBoucleOuverte = 0;
        nbBoucleFini = 0;
        boolBoucleFin = true;
    }

    public void selectInterationPour()
    {
        if (drowdownActif == true)
        {
            listeIteration.Add(choixIter.value + 1);
            listeIterationEnCour.Add(choixIter.value + 1);




            goDrowdown.SetActive(false);
            drowdownActif = false;

            //btFinPour.SetActive(true);
            choixIter.value = 0;

        }       
    }
}
