using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptCptBt : MonoBehaviour
{
    public int stock;
    public Text txtStock;
    public Button button;

    void Start()
    {
        txtStock.text = ("" + stock);
        if (stock <= 0)
        {
            button.interactable = false;
        }
    }

    public void stockMoins()
    {
        stock--;
        txtStock.text = ("" + stock);

        if (stock <= 0)
        {
            button.interactable = false;
        }
    }
}
