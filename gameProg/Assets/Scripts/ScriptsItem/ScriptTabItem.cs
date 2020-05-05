using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTabItem : MonoBehaviour
{
    public enum Item {Null, Key};
    public Item[] tabItem = new Item[] { Item.Null, Item.Null, Item.Null};
}
