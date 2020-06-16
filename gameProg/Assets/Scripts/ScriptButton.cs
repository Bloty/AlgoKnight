using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptButton : MonoBehaviour
{
    public GameObject actionPosXPlus1, actionPosXMoins1, actionPosYPlus1, actionPosYMoins1,
                    actionPour, actionFinPour, actionAttaque, actionFinSi, actionAttendre, finAction;
    //Position des action
    public Transform posAction1, posAction2, posAction3, posAction4, posAction5, posAction6,
                       posAction7, posAction8, posAction9, posAction10, posAction11, posAction12,
                        posAction13, posAction14, posAction15;                       
    private ArrayList listePosAction = new ArrayList();
    //---------------------------

    //bt start
    public GameObject barre;
    public Button buttonStart;
    public int nbAction = 0;
    //---------------------------

    //btPour
    public GameObject selectIteration, btFinPour;
    public ScriptBtFor scriptBtFor;

    //btSi
    public GameObject selectCondition;
    public ScriptBtIf scriptBtIf;

    //btUtiliser
    public GameObject selectItemUtiliser;
    public ScriptBtUtiliser scriptBtUtiliser;

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
    public void instantiatePrefab(GameObject prefab)
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
        buttonStart.interactable = false;     
    }

    //POUR-------------------------------------
    public void buttonPour()
    {
        

        //on instancie
        if (nbAction < listePosAction.Count - 1)
        {
            //récupere le coodonner
            scriptBtFor.listeCoordonne.Add((Transform)listePosAction[nbAction]);

            instantiatePrefab(actionPour);
        }

        selectIteration.SetActive(true);
        scriptBtFor.drowdownActif = true;

        scriptBtFor.nBBouclePour++;

        buttonStart.interactable = false;
    }
    public void buttonFinPour()
    {
        if (nbAction < listePosAction.Count - 1)
        {
            instantiatePrefab(actionFinPour);
        }

        //btFinPour.SetActive(false);

        buttonStart.interactable = true;
    }
    //-------------------------------------------

    //Condition-----------------------------------
    public void buttonSi()
    {
        selectCondition.SetActive(true);
        scriptBtIf.drowdownActif = true;
        buttonStart.interactable = false;
    }

    public void buttonFinSi()
    {
        //on instancie
        if (nbAction < listePosAction.Count - 1)
        {
            //récupere le coodonner
            //scriptBtIf.listeCoordonne.Add((Transform)listePosAction[nbAction]);

            instantiatePrefab(actionFinSi);
        }

        buttonStart.interactable = true;
    }
    //--------------------------------------------

    //Attaque---------------------
    public void buttonAttaque()
    {
        if (nbAction < listePosAction.Count - 1)
        {
            instantiatePrefab(actionAttaque);
        }
    }

    public void buttonUtiliser()
    {
        selectItemUtiliser.SetActive(true);
        scriptBtUtiliser.drowdownActif = true;

        //scriptBtUtiliser.nbUtilisation++;

        buttonStart.interactable = false;
    }

    public void buttonAttendre()
    {
        if (nbAction < listePosAction.Count - 1)
        {
            instantiatePrefab(actionAttendre);
        }
    }
}