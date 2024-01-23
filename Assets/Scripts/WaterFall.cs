using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterFall : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == MyTags.PLAYER_TAG)
        {
            if (tag == MyTags.WATER)
            {

                Quit();
            }
        }
    }
    public void Quit()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
