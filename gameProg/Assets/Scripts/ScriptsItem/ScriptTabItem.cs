using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTabItem : MonoBehaviour
{
    public enum Item {Null, Key};
    public Item[] tabItem = new Item[] { Item.Null, Item.Null, Item.Null};

    public void rangerItem(ScriptTabItem.Item item)
    {
        if (tabItem[0] == ScriptTabItem.Item.Null)
        {
            tabItem[0] = item;
        }
        else
        {
            if (tabItem[1] == ScriptTabItem.Item.Null)
            {
                tabItem[1] = item;
            }
            else
            {
                if (tabItem[2] == ScriptTabItem.Item.Null)
                {
                    tabItem[2] = item;
                }
            }
        }
    }
}
