using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDownLevel2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == MyTags.PLAYER_TAG)
        {
            if (tag == MyTags.DEATH_LAYER_LEVEL2)
            {

                Quit();
            }
        }
    }
    public void Quit()
    {
        SceneManager.LoadScene("Level2");
    }
}
