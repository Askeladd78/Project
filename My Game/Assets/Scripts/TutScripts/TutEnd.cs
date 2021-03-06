﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutEnd : MonoBehaviour
{
    public GameObject panel10;
    public GameObject panel9;
    public GameObject panel7;
    public GameObject panel8;
    public GameObject panel6;
    public GameObject panel5;
    public GameObject panel4;
    public GameObject panel3;
    public GameObject panel2;
    public GameObject panel1;
    public GameObject tutEndSound;

    public Text bestTimeText;
    public static bool isTutFinished = false;

    void OnTriggerEnter(Collider other)
    {

        Destroy(panel9);
        Destroy(panel8);
        Destroy(panel7);
        Destroy(panel6);
        Destroy(panel5);
        Destroy(panel4);
        Destroy(panel3);
        Destroy(panel2);
        Destroy(panel1);
        panel10.SetActive(true);
        Time.timeScale = 0f;
        isTutFinished = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        tutEndSound.GetComponent<AudioSource>().Play();

    }
}
