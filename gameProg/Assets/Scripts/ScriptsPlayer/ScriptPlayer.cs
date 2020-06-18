using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    public enum CouleurCase { neutre, bleu, rouge };
    public CouleurCase couleurCase;

    public GameObject barre;
    public ScriptBarreAction scriptBarreAction;
    public bool colWallXPlus, colWallXMoins, colWallYPlus, colWallYMoins, 
                colEnnemiXPlus, colEnnemiXMoins, colEnnemiYPlus, colEnnemiYMoins;

    public bool bouclier;
    public GameObject goBouclier;

    void Start()
    {
        couleurCase = CouleurCase.neutre;
        bouclier = false;
        goBouclier.SetActive(false);
    }

    void Update()
    {
        if(bouclier == true)
        {
            goBouclier.SetActive(true);
        }
        else
        {
            goBouclier.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Pique") || col.gameObject.CompareTag("Ennemi"))
        {
            if (bouclier == false)
            {
                scriptBarreAction.finAction = true;
                barre.SetActive(false);
            }
            else
            {
                bouclier = false;
            }
        }

        if (col.gameObject.CompareTag("CaseBleu"))
        {
            couleurCase = CouleurCase.bleu;
        }

        if (col.gameObject.CompareTag("CaseRouge"))
        {
            couleurCase = CouleurCase.rouge;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("CaseBleu"))
        {
            couleurCase = CouleurCase.neutre;
        }

        if (col.gameObject.CompareTag("CaseRouge"))
        {
            couleurCase = CouleurCase.neutre;
        }
    }
}
