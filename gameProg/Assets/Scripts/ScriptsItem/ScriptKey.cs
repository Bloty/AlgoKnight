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
            scriptTabItem.rangerItem(ScriptTabItem.Item.Key);

            Destroy(this.gameObject);
        }
    }
}
