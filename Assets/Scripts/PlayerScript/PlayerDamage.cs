using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerDamage : MonoBehaviour
{


    private Text LifeText;
    private int lifeScoreCount;

    private bool canDamage;


    void Awake()
    {
        LifeText = GameObject.Find("LifeText").GetComponent<Text>();
        lifeScoreCount = 5;
        LifeText.text = "x" + lifeScoreCount;

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
                LifeText.text = "x" + lifeScoreCount;
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
        SceneManager.LoadScene("BetweenGame");
    }
}
