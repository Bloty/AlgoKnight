using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptColYMoins : MonoBehaviour
{
    public ScriptPlayer scriptPlayer;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            scriptPlayer.colWallYMoins = true;
        }

        if (col.gameObject.CompareTag("Ennemi"))
        {
            scriptPlayer.colEnnemiYMoins = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            scriptPlayer.colWallYMoins = false;
        }

        if (col.gameObject.CompareTag("Ennemi"))
        {
            scriptPlayer.colEnnemiYMoins = false;
        }
    }
}
