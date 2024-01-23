using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainLevel2 : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Level2");
    }
}
