using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtIf : MonoBehaviour
{
    public ScriptButton scriptButton;
    public bool drowdownActif;
    public GameObject goDrowdown;

    public Dropdown choixCondition;
    public GameObject actionSiBleu, actionSiRouge;

    public int cptSi;


    void Start()
    {
        drowdownActif = false;
        cptSi = 0;
    }

    public void selectCondition()
    {
        if (drowdownActif == true)
        {
            if (choixCondition.value == 1)
            {
                scriptButton.instantiatePrefab(actionSiBleu);
            }
            else
            {
                if (choixCondition.value == 2)
                {
                    scriptButton.instantiatePrefab(actionSiRouge);

                }
            }

            goDrowdown.SetActive(false);
            drowdownActif = false;

            choixCondition.value = 0;
        }
    }
}
