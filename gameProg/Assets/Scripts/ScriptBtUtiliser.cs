using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtUtiliser : MonoBehaviour
{
    //public int nbUtilisation;    
    //public ArrayList listeIndexItem = new ArrayList();
    public bool drowdownActif;
    public GameObject goDrowdown;

    public Dropdown choixIndexItem;
    public Button buttonStart;



    public ScriptButton scriptButton;
    public GameObject actionUseTabCase0, actionUseTabCase1, actionUseTabCase2;
    public ScriptTabItem scriptTabItem;

    void Start()
    {
        drowdownActif = false;
    }

    public void selectCaseTabItem()
    {
        if (drowdownActif == true)
        {
            //listeIndexItem.Add(0);
            //listeIndexItem[nbUtilisation - 1] = choixIndexItem.value;

            if (choixIndexItem.value-1 == 0)
            {
                scriptButton.instantiatePrefab(actionUseTabCase0);
            }
            else
            {
                if (choixIndexItem.value - 1 == 1)
                {
                    scriptButton.instantiatePrefab(actionUseTabCase1);
                }
                else
                {
                    if (choixIndexItem.value - 1 == 2)
                    {
                        scriptButton.instantiatePrefab(actionUseTabCase2);
                    }
                }
            }

            goDrowdown.SetActive(false);
            drowdownActif = false;
    
            choixIndexItem.value = 0;
            buttonStart.interactable = true;
        }
    }
}
