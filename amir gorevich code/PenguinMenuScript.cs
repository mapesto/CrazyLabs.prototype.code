using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PenguinMenuScript : MonoBehaviour
{
  
    public static bool GameIsPaused = false;

    public GameObject puseMenuUI;
    
    public GameObject Body;
    public Material Regular;
    public Material Golden;
    public Material Pink;
    public Material Green;

    public GameObject camra0;
    public GameObject camra1;
    public GameObject camra2;
    public GameObject camra3;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }


    public void TouchMenu()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }



    public void Resume()
    {
        puseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    private void Pause()
    {
        puseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
    public void camraChamge(int val)
    {
        if (val == 0)
        {
            camra0.SetActive(true);
            camra1.SetActive(false);
            camra2.SetActive(false);
            camra3.SetActive(false);
        }
        if (val == 1)
        {
            camra0.SetActive(false);
            camra1.SetActive(true);
            camra2.SetActive(false);
            camra3.SetActive(false);
        }
        if (val == 2)
        {
            camra0.SetActive(false);
            camra1.SetActive(false);
            camra2.SetActive(true);
            camra3.SetActive(false);
        }
        if (val == 3)
        {
            camra0.SetActive(false);
            camra1.SetActive(false);
            camra2.SetActive(false);
            camra3.SetActive(true);
        }
    }
   
           
    
 
    


    public void ColorChamge(int val)
    {
        if (val == 0)
        {
            Body.GetComponent<Renderer>().material = Regular;
        }
        if (val == 1)
        {
            Body.GetComponent<Renderer>().material = Golden;
        }
        if (val == 2)
        {
            Body.GetComponent<Renderer>().material = Pink;
        }
        if (val == 3)
        {
            Body.GetComponent<Renderer>().material = Green;
        }
    }





}
