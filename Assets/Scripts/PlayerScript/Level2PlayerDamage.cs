using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Globalization;

public class Level2PlayerDamage : MonoBehaviour
{
    private Text LifeText2;
    private int lifeScoreCount;

    private bool canDamage;


    void Awake()
    {
        LifeText2 = GameObject.Find("LifeText2").GetComponent<Text>();
        lifeScoreCount = 5;
        LifeText2.text = "x" + lifeScoreCount;

        canDamage = true;
    }

    void Start()
    {
        Time.timeScale = 1f;
    }
    public void DealDamage()
    {
        if (canDamage)
        {
            lifeScoreCount--;
            if (lifeScoreCount >= 0)
            {
                LifeText2.text = "x" + lifeScoreCount;
            }



            if (lifeScoreCount == 0)
            {
                Time.timeScale = 0f;
                StartCoroutine(RestartGame());
            }
            canDamage = false;
            StartCoroutine(WaitForDamage());
        }
    }
    IEnumerator WaitForDamage()
    {
        yield return new WaitForSeconds(2f);
        canDamage = true;
    }
    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        SceneManager.LoadScene("BetweenGameLevel2");
    }
}
