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
    //public Vector3 posPour;

    //if
    public ScriptBtIf scriptBtIf;
    public BoxCollider2D colBarre;
    //public GameObject colCptSi;

    //item
    public ScriptWin scriptWin;
    public ScriptTabItem scriptTabItem;


    public bool finAction;



    void Start()
    {
        finAction = false;
        rb.AddForce(-transform.up * speed, ForceMode2D.Impulse);
        //colCptSi.SetActive(false);
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

            //posPour = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            //-1 iteration
            //scriptBtFor.listeIteration[scriptBtFor.listeIteration.Count - scriptBtFor.nBBouclePour] = (int)scriptBtFor.listeIteration[scriptBtFor.listeIteration.Count - scriptBtFor.nBBouclePour] - 1;

            //----------------------------------------------------------------------------
            //incrémentation du nb de boucle ouverte
            scriptBtFor.nbBoucleOuverte++;
            //on reinitialise le nb itération de la boucle en cour avec la liste d'iteration
            scriptBtFor.listeIterationEnCour[((scriptBtFor.nbBoucleOuverte) + (scriptBtFor.nbBoucleFini)) - 1] = scriptBtFor.listeIteration[((scriptBtFor.nbBoucleOuverte) + (scriptBtFor.nbBoucleFini)) - 1];
            //-----------------------------------------------------------------------------
        }

        if (col.gameObject.CompareTag("ActionFinPour"))
        {
            //Debug.Log("0 : "+ scriptBtFor.listeIterationEnCour[0]);
            //Debug.Log("1 : " + scriptBtFor.listeIterationEnCour[1]);
            //Debug.Log("2 : " + scriptBtFor.listeIterationEnCour[2]);
            // Debug.Log("3 : " + scriptBtFor.listeIterationEnCour[3]);
            /*
            if ((int)scriptBtFor.listeIteration[scriptBtFor.listeIteration.Count - scriptBtFor.nBBouclePour] >= 0)
            {
                transform.position = posPour;
            }
            else
            {
                scriptBtFor.nBBouclePour--;
            }*/

            //----------------------------------------------
            //on décrémante itération de la boucle en cour
            scriptBtFor.listeIterationEnCour[((scriptBtFor.nbBoucleOuverte) + (scriptBtFor.nbBoucleFini)) - 1] = (int)scriptBtFor.listeIterationEnCour[((scriptBtFor.nbBoucleOuverte) + (scriptBtFor.nbBoucleFini)) - 1] - 1;
            

            if ((int)scriptBtFor.listeIterationEnCour[((scriptBtFor.nbBoucleOuverte) + (scriptBtFor.nbBoucleFini)) -1] >= 1)
            {
                //deplacer la barre
                Transform coordPour;
                coordPour = (Transform)scriptBtFor.listeCoordonne[((scriptBtFor.nbBoucleOuverte) + (scriptBtFor.nbBoucleFini)) - 1];
                transform.position = new Vector3(transform.position.x, coordPour.position.y, 0);

            }
            else
            {   
                if ((scriptBtFor.nbBoucleOuverte + scriptBtFor.nbBoucleFini) -1 != 0)
                {
                    Debug.Log((scriptBtFor.nbBoucleOuverte + scriptBtFor.nbBoucleFini) - 1);
                    for (int i = 0; i < (scriptBtFor.nbBoucleOuverte + scriptBtFor.nbBoucleFini)-1 ; i++)
                    {
                        Debug.Log(i);
                        if ((int)scriptBtFor.listeIterationEnCour[i] > 1)
                        {
                            scriptBtFor.boolBoucleFin = false;
                        }
                    }
                }
                else
                {
                    scriptBtFor.boolBoucleFin = true;
                }

                if (scriptBtFor.boolBoucleFin == true)
                {
                    scriptBtFor.nbBoucleFini++;
                }

                scriptBtFor.boolBoucleFin = true;
                scriptBtFor.nbBoucleOuverte--;
            }
            //----------------------------------------------

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

        //Condition SI-------------------------------------

        if (col.gameObject.CompareTag("ActionCaseBleu"))
        {
            if (scriptPlayer.couleurCase != ScriptPlayer.CouleurCase.bleu)
            {
                //deplacer la barre
                /*
                Transform coordFinSI;
                coordFinSI = (Transform)scriptBtIf.listeCoordonne[0];
                transform.position = new Vector3(transform.position.x, coordFinSI.position.y, 0);
                */

                colBarre.enabled = false;
            }
            else
            {
                scriptBtIf.cptSi--;
            }
        }

        if (col.gameObject.CompareTag("ActionCaseRouge"))
        {
            if (scriptPlayer.couleurCase == ScriptPlayer.CouleurCase.rouge)
            {
                Debug.Log("cest rouge");
            }
        }

        if (col.gameObject.CompareTag("ActionFinSI"))
        {
            if (scriptBtIf.cptSi > 0)
            {
                scriptBtIf.cptSi--;
            }

            if (scriptBtIf.cptSi == 0)
            {
                colBarre.enabled = true;
            }
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
