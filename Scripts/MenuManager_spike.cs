﻿using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MenuManager_spike : MonoBehaviour
{
    public GameObject deathPanel;
    public GameObject canvasObj;
    public GameObject walls;
    public GameObject startPanel;

    public AudioSource source;

    public AudioClip jump;
    public AudioClip death;
    


    void Start()
    {


        deathPanel = GameObject.Find("DeathScreen");
        deathPanel.SetActive(false);
        source = GetComponent<AudioSource>();
        startPanel = GameObject.Find("StartScreen");
        startPanel.SetActive(true);
        canvasObj = GameObject.Find("Canvas");

       // panel_loading = GameObject.Find("Panel_loading");
    }

    

    public void jumpSound()
    {
        source.PlayOneShot(jump, 1);
    }
    public void deathSound()
    {
        source.PlayOneShot(death, 1);
    }

    public void setWallsOff()
    {
        walls.SetActive(false);
    }

    public void setWallsOn()
    {
        walls.SetActive(true);
    }

    public void switchToDeath()
    {
        setWallsOff();
        deathPanel.SetActive(true);

    }

    public void startTheGame()
    {
        startPanel.SetActive(false);
        setWallsOn();
    }
    
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
    public void home()
    {
       GameObject.Find("Player").GetComponent<Player_spike>().panel_loading.SetActive(true);
       SceneManager.LoadSceneAsync(0 , LoadSceneMode.Single);  
    }
}
