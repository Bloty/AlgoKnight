using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPotionBouclier : MonoBehaviour
{
    public ScriptTabItem scriptTabItem;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            scriptTabItem.rangerItem(ScriptTabItem.Item.PotionBouclier);

            Destroy(this.gameObject);
        }
    }
}
