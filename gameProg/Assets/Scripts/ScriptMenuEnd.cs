﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenuEnd : MonoBehaviour
{
    private ArrayList listLevel = new ArrayList();

    void Start()
    {
        listLevel.Add("Test");
        listLevel.Add("Level1");
        listLevel.Add("Level2");
        //Debug.Log((string)listLevel[ScriptVarGlobal.level]);
    }


    public void nextLevel()
    {
        ScriptVarGlobal.level++;
        SceneManager.LoadScene((string)listLevel[ScriptVarGlobal.level]);
        
    }
    public void reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
