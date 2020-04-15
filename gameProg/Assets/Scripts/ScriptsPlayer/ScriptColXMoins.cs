using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptColXMoins : MonoBehaviour
{
    public ScriptPlayer scriptPlayer;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            scriptPlayer.colWallXMoins = true;
        }

        if (col.gameObject.CompareTag("Ennemi"))
        {
            scriptPlayer.colEnnemiXMoins = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            scriptPlayer.colWallXMoins = false;
        }

        if (col.gameObject.CompareTag("Ennemi"))
        {
            scriptPlayer.colEnnemiXMoins = false;
        }
    }
}
