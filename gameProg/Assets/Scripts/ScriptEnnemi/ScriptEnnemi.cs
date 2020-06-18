using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnnemi : MonoBehaviour
{
    public int life;

    public GameObject colHitXPlus, colHitXMoins, colHitYPlus, colHitYMoins;

    public ScriptPlayer scriptPlayer;
    public GameObject colXPlus, colXMoins, colYPlus, colYMoins;
    public GameObject animAttaque;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Hit"))
        {
            Debug.Log("Hit");
            life--;

            if (scriptPlayer.colEnnemiXPlus)
            {
                Instantiate(animAttaque, colXPlus.transform);
            }
            if (scriptPlayer.colEnnemiXMoins)
            {
                Instantiate(animAttaque, colXMoins.transform);
            }
            if (scriptPlayer.colEnnemiYPlus)
            {
                Instantiate(animAttaque, colYPlus.transform);
            }
            if (scriptPlayer.colEnnemiYMoins)
            {
                Instantiate(animAttaque, colYMoins.transform);
            }


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
