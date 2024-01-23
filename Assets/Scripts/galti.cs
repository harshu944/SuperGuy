using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class galti : MonoBehaviour
{
    public void Quit()
    {
        SceneManager.LoadScene("HomeQuit");
    }
}
