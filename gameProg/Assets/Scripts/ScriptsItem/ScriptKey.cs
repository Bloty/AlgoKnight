using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptKey : MonoBehaviour
{
    public ScriptTabItem scriptTabItem;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

            if (scriptTabItem.tabItem[0] == ScriptTabItem.Direction.Null)
            {
                scriptTabItem.tabItem[0] = ScriptTabItem.Direction.Key;
            }
            else
            {
                if (scriptTabItem.tabItem[1] == ScriptTabItem.Direction.Null)
                {
                    scriptTabItem.tabItem[1] = ScriptTabItem.Direction.Key;
                }
                else
                {
                    if (scriptTabItem.tabItem[2] == ScriptTabItem.Direction.Null)
                    {
                        scriptTabItem.tabItem[2] = ScriptTabItem.Direction.Key;
                    }
                }
            }

            Destroy(this.gameObject);
        }
    }
}
