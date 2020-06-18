using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOeilVolant : MonoBehaviour
{
    private enum EtatDeplacement { Haut, Bas };
    private EtatDeplacement etatDeplacement;

    public ScriptBarreAction scriptBarreAction;
    private int nbActionFaite;

    public ScriptPlayer scriptPlayer;



    void Start()
    {
        nbActionFaite = 0;
        etatDeplacement = EtatDeplacement.Haut;
    }

    void Update()
    {
        if (scriptBarreAction.nbActionFaite != nbActionFaite)
        {
            nbActionFaite = scriptBarreAction.nbActionFaite;

            if (scriptBarreAction.nbActionFaite % 2 == 0)
            {
                if (etatDeplacement == EtatDeplacement.Haut)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
                    etatDeplacement = EtatDeplacement.Bas;
                }
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                    etatDeplacement = EtatDeplacement.Haut;
                }
            }
        }
    }
}
