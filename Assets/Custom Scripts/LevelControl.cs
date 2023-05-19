using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public static LevelControl instance = null; 
    int levelPassed;

    // Use this for initialization
    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }

    //public void youWinLevel1()
    //{
    //    PlayerPrefs.SetInt("LevelPassed", 2);
    //    Invoke("loadMainMenu", 1f);
    //}

    public void youWinLevel0()
    {
        if (PlayerPrefs.GetInt("LevelPassed") == 0) //ngecek dia ngulang level ato baru kelar level pertama kali
        {
            PlayerPrefs.SetInt("LevelPassed", 1);
            Invoke("loadMainMenu", 1f);
        }
        Invoke("loadMainMenu", 1f);
    }

    public void youWinLevel1()
    {
        if (PlayerPrefs.GetInt("LevelPassed") == 1)
        {
            PlayerPrefs.SetInt("LevelPassed", 2);
            Invoke("loadMainMenu", 1f);
        }
        Invoke("loadMainMenu", 1f);
    }

    public void youWinLevel2()
    {
        if (PlayerPrefs.GetInt("LevelPassed") == 2)
        {
            PlayerPrefs.SetInt("LevelPassed", 3);
            Invoke("loadMainMenu", 1f);
        }
        Invoke("loadMainMenu", 1f);
    }

    public void youWinLevel3()
    {
        if (PlayerPrefs.GetInt("LevelPassed") == 3)
        {
            PlayerPrefs.SetInt("LevelPassed", 4);
            Invoke("loadMainMenu", 1f);
        }
        Invoke("loadMainMenu", 1f);
    }

    public void youWinLevel4()
    {
        if (PlayerPrefs.GetInt("LevelPassed") == 4)
        {
            PlayerPrefs.SetInt("LevelPassed", 5);
            Invoke("loadMainMenu", 1f);
        }
        Invoke("loadMainMenu", 1f);
    }

    public void youWinLevel5()
    {
        if (PlayerPrefs.GetInt("LevelPassed") == 5)
        {
            PlayerPrefs.SetInt("LevelPassed", 6);
            Invoke("loadMainMenu", 1f);
        }
        Invoke("loadMainMenu", 1f);
    }

    public void youWinLevel6a() //good end
    {
        if (PlayerPrefs.GetInt("LevelPassed") == 6)
        {
            PlayerPrefs.SetInt("LevelPassed", 7); //baru clear good end
            Invoke("loadMainMenu", 1f);
        }else if(PlayerPrefs.GetInt("LevelPassed") == 8) //udah clear bad end sebelumnya
        {
            PlayerPrefs.SetInt("LevelPassed", 9);
            Invoke("loadMainMenu", 1f);
        }
        Invoke("loadMainMenu", 1f);
    }

    public void youWinLevel6b() //bad end
    {
        if (PlayerPrefs.GetInt("LevelPassed") == 6)
        {
            PlayerPrefs.SetInt("LevelPassed", 8); //baru clear bad end
            Invoke("loadMainMenu", 1f);
        }
        else if (PlayerPrefs.GetInt("LevelPassed") == 7) //udah clear good end sebelumnya
        {
            PlayerPrefs.SetInt("LevelPassed", 9);
            Invoke("loadMainMenu", 1f);
        }
        Invoke("loadMainMenu", 1f);
    }

    public void youLose()
    {
        Invoke("loadMainMenu", 1f);
    }

    void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void mainMenuBtn()
    {
        SceneManager.LoadScene("MainMenu");
      
    }
}
