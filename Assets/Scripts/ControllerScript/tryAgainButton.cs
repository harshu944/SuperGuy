﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tryAgainButton : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("GamePlay");
    }
}