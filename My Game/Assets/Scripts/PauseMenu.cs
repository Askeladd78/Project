﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject pauseMenuUI;

    public Slider newMusicSlider, newSoundEffectSlider;


    void Start()
    {
        pauseMenuUI.SetActive(false);

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (isGamePaused)
            {

                ResumeGame();
            }
            else
            {

                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        Cursor.lockState = CursorLockMode.None;


    }

    public void GoToSettings() {

        Time.timeScale = 0f;
        SceneManager.LoadScene("StartMenu");

    }

    public void GoToMainMenu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {

        Application.Quit();

    }

    //Continue Settings From Main Menu To Other Scenes
    //private void ContinueSettings()
    //{

       // newMusicSlider = AudioManager.musicSlider;
        //newSoundEffectSlider = AudioManager.soundEffectSlider;
    //}
}
