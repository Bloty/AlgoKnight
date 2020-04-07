using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptBarreAction : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    public Transform posPlayer;
    public ScriptPlayer scriptPlayer;

    public ScriptBtFor scriptBtFor;
    public Vector3 posPour;


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
            Debug.Log("POUR");
            //Debug.Log(scriptBtFor.listeIteration[0]);

            posPour = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            scriptBtFor.listeIteration[0] = (int)scriptBtFor.listeIteration[0] - 1;

        }

        if (col.gameObject.CompareTag("ActionFinPour"))
        {
            Debug.Log("Fin POUR");

            if ((int)scriptBtFor.listeIteration[0] >= 0)
            {
                transform.position = posPour;
            }
        }
        //----------------------------------------------
        //fin de l'algo
        if (col.gameObject.CompareTag("FinAction"))
        {
            Debug.Log("Fin Action");
            finAction = true;

            this.gameObject.SetActive(false);
        }
    }
}
