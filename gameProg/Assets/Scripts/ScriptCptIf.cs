using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCptIf : MonoBehaviour
{
    public ScriptBtIf scriptBtIf;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("CptSi"))
        {
            Debug.Log("+1");
            scriptBtIf.cptSi++;
        }
    }
}
