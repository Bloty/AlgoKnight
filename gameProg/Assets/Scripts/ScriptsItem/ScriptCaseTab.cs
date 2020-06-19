using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCaseTab : MonoBehaviour
{
    public ScriptTabItem scriptTabItem;
    public GameObject spritKey, spritPotionBouclier;
    public int numeroCase;


    //activer les sprite dans le tableau
    void Update()
    {
        if (scriptTabItem.tabItem[numeroCase] == ScriptTabItem.Item.Key)
        {
            spritKey.SetActive(true);
        }
        else
        {
            spritKey.SetActive(false);
        }

        if (scriptTabItem.tabItem[numeroCase] == ScriptTabItem.Item.PotionBouclier)
        {
            spritPotionBouclier.SetActive(true);
        }
        else
        {
            spritPotionBouclier.SetActive(false);
        }
    }
}
