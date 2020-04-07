﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptButton : MonoBehaviour
{
    public GameObject actionPosXPlus1, actionPosXMoins1, actionPosYPlus1, actionPosYMoins1, actionPour, actionFinPour, finAction;
    //Position des action
    public Transform posAction1, posAction2, posAction3, posAction4, posAction5, posAction6,
                       posAction7, posAction8, posAction9, posAction10, posAction11, posAction12,
                        posAction13, posAction14, posAction15;                       
    private ArrayList listePosAction = new ArrayList();
    //---------------------------

    //bt start
    public GameObject barre;
    public Button button;
    public int nbAction = 0;
    //---------------------------

    //btPour
    public GameObject selectIteration, btFinPour;
    public ScriptBtFor scriptBtFor;

    void Start()
    {
        listePosAction.Add(posAction1);
        listePosAction.Add(posAction2);
        listePosAction.Add(posAction3);
        listePosAction.Add(posAction4);
        listePosAction.Add(posAction5);
        listePosAction.Add(posAction6);
        listePosAction.Add(posAction7);
        listePosAction.Add(posAction8);
        listePosAction.Add(posAction9);
        listePosAction.Add(posAction10);
        listePosAction.Add(posAction11);
        listePosAction.Add(posAction12);
        listePosAction.Add(posAction13);
        listePosAction.Add(posAction14);
        listePosAction.Add(posAction15);        
    }

    //instancier un prefab
    private void instantiatePrefab(GameObject prefab)
    {
        Instantiate(prefab, (Transform)listePosAction[nbAction]);
        nbAction++;
    }

    //position en X +1
    public void posXPlus()
    {
        if (nbAction < listePosAction.Count - 1)
        {
            instantiatePrefab(actionPosXPlus1);
        }    
    }

    //position en X -1
    public void posXMoins()
    {
        if (nbAction < listePosAction.Count - 1)
        {
            instantiatePrefab(actionPosXMoins1);
        }
    }

    //position en Y +1
    public void posYPlus()
    {
        if (nbAction < listePosAction.Count - 1)
        {
            instantiatePrefab(actionPosYPlus1);
        }
    }

    //position en Y -1
    public void posYMoins()
    {
        if (nbAction < listePosAction.Count - 1)
        {
            instantiatePrefab(actionPosYMoins1);
        }
    }

    //instancier la fin de l'algo
    public void posFinAction()
    {
        if (nbAction < listePosAction.Count)
        {
            instantiatePrefab(finAction);
        }
        
        barre.SetActive(true);
        button.interactable = false;     
    }

    //POUR-------------------------------------
    public void buttonPour()
    {
        if (nbAction < listePosAction.Count - 1)
        {
            instantiatePrefab(actionPour);
        }

        selectIteration.SetActive(true);
        scriptBtFor.nBBouclePour++;
    }
    public void buttonFinPour()
    {
        if (nbAction < listePosAction.Count - 1)
        {
            instantiatePrefab(actionFinPour);
        }

        selectIteration.SetActive(false);
        btFinPour.SetActive(false);
    }
    //-------------------------------------------
}