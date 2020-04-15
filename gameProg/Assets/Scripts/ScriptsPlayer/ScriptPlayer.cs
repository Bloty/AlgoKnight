using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    public GameObject barre;
    public ScriptBarreAction scriptBarreAction;
    public bool colWallXPlus, colWallXMoins, colWallYPlus, colWallYMoins, 
                colEnnemiXPlus, colEnnemiXMoins, colEnnemiYPlus, colEnnemiYMoins;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Pique") || col.gameObject.CompareTag("Ennemi"))
        {
            scriptBarreAction.finAction = true;
            barre.SetActive(false);
        }
    }
}
