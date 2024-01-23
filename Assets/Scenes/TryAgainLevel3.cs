
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainLevel3 : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Level3");
    }
}