using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnnemi : MonoBehaviour
{
    public int life;

    public GameObject colHitXPlus, colHitXMoins, colHitYPlus, colHitYMoins;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Hit"))
        {
            Debug.Log("Hit");
            life--;

            if (life <= 0)
            {
                Destroy(this.gameObject);
            }

            colHitXPlus.SetActive(false);
            colHitXMoins.SetActive(false);
            colHitYPlus.SetActive(false);
            colHitYMoins.SetActive(false);
        }
    }
}
