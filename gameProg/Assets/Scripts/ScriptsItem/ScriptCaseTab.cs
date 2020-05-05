using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCaseTab : MonoBehaviour
{
    public ScriptTabItem scriptTabItem;
    public GameObject spritKey;
    public int numeroCase;

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
    }
}
