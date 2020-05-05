using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtFor: MonoBehaviour
{
    public int nBBouclePour;
    public GameObject btFinPour, goDrowdown;
    public ArrayList listeIteration = new ArrayList();
    public Dropdown choixIter;
    public bool drowdownActif;

    void Start()
    {
        drowdownActif = false;  
    }

    public void selectInterationPour()
    {
        if (drowdownActif == true)
        {
            listeIteration.Add(0);
            listeIteration[nBBouclePour - 1] = choixIter.value;
            

            goDrowdown.SetActive(false);
            drowdownActif = false;

            btFinPour.SetActive(true);
            choixIter.value = 0;

        }       
    }
}
