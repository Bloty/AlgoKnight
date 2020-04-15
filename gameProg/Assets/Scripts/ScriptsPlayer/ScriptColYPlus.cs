using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptColYPlus : MonoBehaviour
{
    public ScriptPlayer scriptPlayer;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            scriptPlayer.colWallYPlus = true;
        }

        if (col.gameObject.CompareTag("Ennemi"))
        {
            scriptPlayer.colEnnemiYPlus = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            scriptPlayer.colWallYPlus = false;
        }

        if (col.gameObject.CompareTag("Ennemi"))
        {
            scriptPlayer.colEnnemiYPlus = false;
        }
    }
}
