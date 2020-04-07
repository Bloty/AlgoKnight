using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    public GameObject barre;
    public ScriptBarreAction scriptBarreAction;
    public bool colWallXPlus, colWallXMoins, colWallYPlus, colWallYMoins;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Pique"))
        {
            scriptBarreAction.finAction = true;
            barre.SetActive(false);
        }
    }
}
