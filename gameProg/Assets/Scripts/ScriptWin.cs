using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptWin : MonoBehaviour
{
    public ScriptBarreAction scriptBarreAction;
    //var menu
    public GameObject menuWin, menuLose;
    public Transform transformUi;


    public bool inWin, finDuLevel;

    void Start()
    {
        inWin = false;
        finDuLevel = false;
    }

    void Update()
    {
        if (inWin == true && scriptBarreAction.finAction == true && finDuLevel == false)
        {
            Debug.Log("WIN!!!");
            finDuLevel = true;
            Instantiate(menuWin, transformUi);
        }
        else
        {
            if (scriptBarreAction.finAction == true && finDuLevel == false)
            {
                Debug.Log("LOSE");
                finDuLevel = true;
                Instantiate(menuLose, transformUi);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            inWin = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            inWin = false;
        }
    }
}

