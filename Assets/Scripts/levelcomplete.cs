using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplete : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == MyTags.PLAYER_TAG)
        {
            if (tag == MyTags.LEVEL_COMPLETE)
            {

                Quit();
            }
        }
    }
    public void Quit()
    {
        SceneManager.LoadScene("LevelComplete");
    }
}
        
