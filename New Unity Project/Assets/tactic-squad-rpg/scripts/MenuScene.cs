﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour {

    private CanvasGroup fadeGroup;
    private float fadeInSpeed = 0.33f;

    private void Start()
    {
        fadeGroup = FindObjectOfType<CanvasGroup>();

        fadeGroup.alpha = 1;
    }

    private void Update()
    {
        fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;
    }

    // Buttons
    public void OnPlayClick()
    {
        Debug.Log("Play button has been clicked!");
        SceneManager.LoadScene("MainPlay");
    }

}
