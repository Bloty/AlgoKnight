using System.Collections;
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
        listLevel.Add("Level3");
        listLevel.Add("Level4");
        listLevel.Add("Level5");
        listLevel.Add("Level6");
        listLevel.Add("Level7");
        listLevel.Add("Level8");
        listLevel.Add("Level9");
        listLevel.Add("Level10");
        listLevel.Add("Level11");
        listLevel.Add("Level12");
        listLevel.Add("Level13");
        listLevel.Add("Level14");
        listLevel.Add("Level15");
        listLevel.Add("Level16");
        listLevel.Add("SceneFin");
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

    public void menuPrincipal()
    {
        SceneManager.LoadScene("menu_principal");
    }
}
