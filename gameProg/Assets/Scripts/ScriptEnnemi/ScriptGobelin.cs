﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGobelin : MonoBehaviour
{
    private enum EtatDeplacement { gauche, droite };
    private EtatDeplacement etatDeplacement;

    public ScriptBarreAction scriptBarreAction;
    private int nbActionFaite;

    public ScriptPlayer scriptPlayer;

    

    void Start()
    {
        nbActionFaite = 0;
        etatDeplacement = EtatDeplacement.gauche;
    }

    void Update()
    {
        //deplacement du gobelin
        if (scriptBarreAction.nbActionFaite != nbActionFaite)
        {
            nbActionFaite = scriptBarreAction.nbActionFaite;

            if (scriptBarreAction.nbActionFaite % 2 == 0)
            {
                if (etatDeplacement == EtatDeplacement.gauche)
                {
                    transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                    etatDeplacement = EtatDeplacement.droite;    
                }
                else
                {
                    transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                    etatDeplacement = EtatDeplacement.gauche;                  
                }                
            }
        }
    }
}
