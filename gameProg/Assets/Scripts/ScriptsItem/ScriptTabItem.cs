using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTabItem : MonoBehaviour
{
    public enum Direction {Null, Key};
    public Direction[] tabItem = new Direction[] { Direction.Null, Direction.Null, Direction.Null};
}
