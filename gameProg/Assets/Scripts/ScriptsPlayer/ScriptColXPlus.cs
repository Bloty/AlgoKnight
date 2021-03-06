﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptColXPlus : MonoBehaviour
{
    public ScriptPlayer scriptPlayer;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            scriptPlayer.colWallXPlus = true;
        }

        if (col.gameObject.CompareTag("Ennemi"))
        {
            scriptPlayer.colEnnemiXPlus = true;
        }
    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            scriptPlayer.colWallXPlus = false;
        }

        if (col.gameObject.CompareTag("Ennemi"))
        {
            scriptPlayer.colEnnemiXPlus = false;
        }
    }
}
