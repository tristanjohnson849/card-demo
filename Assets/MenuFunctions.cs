﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
    public void AccessMainMenu ()
    {
        SceneManager.LoadScene(0);
    }
}
