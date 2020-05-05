using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptBarreAction : MonoBehaviour
{
    //barre
    public float speed;
    public Rigidbody2D rb;
    
    //player
    public Transform posPlayer;
    public ScriptPlayer scriptPlayer;
    public GameObject colHitXPlus, colHitXMoins, colHitYPlus, colHitYMoins;

    //for
    public ScriptBtFor scriptBtFor;
    public Vector3 posPour;

    //item
    public ScriptWin scriptWin;
    public ScriptTabItem scriptTabItem;


    public bool finAction;



    void Start()
    {
        finAction = false;
        rb.AddForce(-transform.up * speed, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //deplacer le joueur
        //x+1
        if (col.gameObject.CompareTag("ActionPosXPlus1") && scriptPlayer.colWallXPlus == false)
        {
            posPlayer.position = new Vector3(posPlayer.position.x + 1, posPlayer.position.y, -0.1f);
        }
        //x-1
        if (col.gameObject.CompareTag("ActionPosXMoins1") && scriptPlayer.colWallXMoins == false)
        {
            posPlayer.position = new Vector3(posPlayer.position.x - 1, posPlayer.position.y, -0.1f);
        }

        //y+1
        if (col.gameObject.CompareTag("ActionPosYPlus1") && scriptPlayer.colWallYPlus == false)
        {
            posPlayer.position = new Vector3(posPlayer.position.x, posPlayer.position.y + 1, -0.1f);
        }

        //y-1
        if (col.gameObject.CompareTag("ActionPosYMoins1") && scriptPlayer.colWallYMoins == false)
        {
            posPlayer.position = new Vector3(posPlayer.position.x, posPlayer.position.y -1, -0.1f);
        }

        //POur-------------------------------------------
        if (col.gameObject.CompareTag("ActionPour"))
        {
            //Debug.Log("POUR");

            posPour = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            scriptBtFor.listeIteration[scriptBtFor.listeIteration.Count - scriptBtFor.nBBouclePour] = (int)scriptBtFor.listeIteration[scriptBtFor.listeIteration.Count - scriptBtFor.nBBouclePour] - 1;

        }

        if (col.gameObject.CompareTag("ActionFinPour"))
        {
            //Debug.Log("Fin POUR");

            if ((int)scriptBtFor.listeIteration[scriptBtFor.listeIteration.Count - scriptBtFor.nBBouclePour] >= 0)
            {
                transform.position = posPour;
            }
            else
            {
                scriptBtFor.nBBouclePour--;
            }
        }
        //----------------------------------------------

        //attaque/------------------------------------------
        if (col.gameObject.CompareTag("ActionAttaque"))
        {
            if (scriptPlayer.colEnnemiXPlus == true)
            {
                colHitXPlus.SetActive(true);
            }

            if (scriptPlayer.colEnnemiXMoins == true)
            {
                colHitXMoins.SetActive(true);
            }

            if (scriptPlayer.colEnnemiYPlus == true)
            {
                colHitYPlus.SetActive(true);
            }

            if (scriptPlayer.colEnnemiYMoins == true)
            {
                colHitYMoins.SetActive(true);
            }
        }

        //Use case---------------------------------
        //case 0
        if (col.gameObject.CompareTag("Case0"))
        {
            Debug.Log("Use case 0");
            //Key paramrtre possible(int index)
            if (scriptTabItem.tabItem[0] == ScriptTabItem.Item.Key && scriptWin.inWin == true)
            {
                scriptWin.isOpen = true;
                scriptTabItem.tabItem[0] = ScriptTabItem.Item.Null;
                Debug.Log("porte ouvert");
            }
            
        }
        //case 1
        if (col.gameObject.CompareTag("Case1"))
        {
            Debug.Log("Use case 1");
        }
        //case 2
        if (col.gameObject.CompareTag("Case2"))
        {
            Debug.Log("Use case 2");
        }

        //------------------------------------------------
        //fin de l'algo
        if (col.gameObject.CompareTag("FinAction"))
        {
            //Debug.Log("Fin Action");
            finAction = true;

            this.gameObject.SetActive(false);
        }
    }
}
