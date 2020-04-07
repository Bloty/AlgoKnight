using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtFor: MonoBehaviour
{
    public int nBBouclePour, nBBouclePourAfaire, nI1, nI2, nI3;
    public GameObject btFinPour;
    public ArrayList listeIteration = new ArrayList();
    public Dropdown choixIter;

    void Start()
    {
        nI1 = 0;
        nI2 = 0;
        nI3 = 0;
        listeIteration.Add(nI1);
        listeIteration.Add(nI2);
        listeIteration.Add(nI3);
    }

    public void selectInterationPour()
    {
        listeIteration[nBBouclePour - 1] = choixIter.value;
        btFinPour.SetActive(true);
        //choixIter.value = 0;
    }
}
