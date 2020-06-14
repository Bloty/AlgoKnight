using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    public enum CouleurCase { neutre, bleu, rouge };

    public GameObject barre;
    public ScriptBarreAction scriptBarreAction;
    public bool colWallXPlus, colWallXMoins, colWallYPlus, colWallYMoins, 
                colEnnemiXPlus, colEnnemiXMoins, colEnnemiYPlus, colEnnemiYMoins;
    public CouleurCase couleurCase;

    void Start()
    {
        couleurCase = CouleurCase.neutre;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Pique") || col.gameObject.CompareTag("Ennemi"))
        {
            scriptBarreAction.finAction = true;
            barre.SetActive(false);
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
