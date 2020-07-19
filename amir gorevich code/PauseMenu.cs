using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{


    public GameObject GameOverMenu;
    public GameObject GameWonMenu;
    public static bool GameIsPaused = false;

    public GameObject puseMenuUI;
    public GameObject SkinpuseMenuUI;

    public GameObject Body;
    public Material Regular;
    public Material Golden;
    public Material Pink;
    public Material Green;

    public GameObject Camera0;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;

    public Move move;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
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

    public void SkinMenu()
    {
        if (GameIsPaused)
        {
            Resume1();
        }
        else
        {
            Pause1();
        }
    }

    public void camraChamge(int val)
    {
        if (val == 0)
        {
            Camera0.SetActive(true);
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
        }
        if (val == 1)
        {
            Camera0.SetActive(false);
            Camera1.SetActive(true);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
        }
        if (val == 2)
        {
            Camera0.SetActive(false);
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            Camera3.SetActive(false);
        }
        if (val == 3)
        {
            Camera0.SetActive(false);
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(true);
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

    public void Resume()
    {
        puseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        puseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        move.speedModifier = 0;



    }
    public void Resume1()
    {
        SkinpuseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
      
    }
    public void Pause1()
    {
        SkinpuseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        
    }

    public void LodeMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
         
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        GameOverMenu.SetActive(true);
      
    }

    public void GameWon()
    {
        Time.timeScale = 0f;
        GameWonMenu.SetActive(true);
        
    }



}
