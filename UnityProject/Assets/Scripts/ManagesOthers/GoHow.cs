﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHow : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("HowTo");
    }
}
