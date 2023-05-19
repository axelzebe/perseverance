using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayMenuControl : MonoBehaviour
{
    //level 01 = chapter 0, level 08 = good end, level 09 = bad end
    public Button level01Btn, level02Btn, level03Btn, level04Btn, level05Btn, level06Btn, level07Btn, level08Btn, level09Btn, levelBonusBtn;
    int levelPassed;
    //public bool isChapter0Clear, isChapter1Clear, isChapter2Clear, isChapter3Clear, isChapter4Clear, isChapter5Clear, isChapter6aClear, isChapter6bClear;

    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level01Btn.interactable = true;
        level02Btn.interactable = false;
        level03Btn.interactable = false;
        level04Btn.interactable = false;
        level05Btn.interactable = false;
        level06Btn.interactable = false;
        level07Btn.interactable = false;
        level08Btn.interactable = false;
        level09Btn.interactable = false;
        levelBonusBtn.interactable = false;

        switch (levelPassed)
        {
            case 1: //chapter 0 clear
                level02Btn.interactable = true;
                break;
            case 2: //chapter 1 clear
                level02Btn.interactable = true;
                level03Btn.interactable = true;
                break;
            case 3: //chapter 2 clear
                level02Btn.interactable = true;
                level03Btn.interactable = true;
                level04Btn.interactable = true;
                break;
            case 4: //chapter 3 clear
                level02Btn.interactable = true;
                level03Btn.interactable = true;
                level04Btn.interactable = true;
                level05Btn.interactable = true;
                break;
            case 5: //chapter 4 clear
                level02Btn.interactable = true;
                level03Btn.interactable = true;
                level04Btn.interactable = true;
                level05Btn.interactable = true;
                level06Btn.interactable = true;
                break;
            case 6: //chapter 5 clear
                level02Btn.interactable = true;
                level03Btn.interactable = true;
                level04Btn.interactable = true;
                level05Btn.interactable = true;
                level06Btn.interactable = true;
                level07Btn.interactable = true;
                break;
            case 7: //chapter 6 clear - good end
                level02Btn.interactable = true;
                level03Btn.interactable = true;
                level04Btn.interactable = true;
                level05Btn.interactable = true;
                level06Btn.interactable = true;
                level07Btn.interactable = true;
                level08Btn.interactable = true;        
                break;
            case 8: //chapter 6 clear - bad end
                level02Btn.interactable = true;
                level03Btn.interactable = true;
                level04Btn.interactable = true;
                level05Btn.interactable = true;
                level06Btn.interactable = true;
                level07Btn.interactable = true;
                level09Btn.interactable = true;
                break;
            case 9: //all unlocked
                level01Btn.interactable = true;
                level02Btn.interactable = true;
                level03Btn.interactable = true;
                level04Btn.interactable = true;
                level05Btn.interactable = true;
                level06Btn.interactable = true;
                level07Btn.interactable = true;
                level08Btn.interactable = true;
                level09Btn.interactable = true;
                levelBonusBtn.interactable = true;
                break;
        }
    }

    public void levelToLoad(int level) //level load
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPrefs() //reset level
    {
        level02Btn.interactable = false;
        level03Btn.interactable = false;
        level04Btn.interactable = false;
        level05Btn.interactable = false;
        level06Btn.interactable = false;
        level07Btn.interactable = false;
        level08Btn.interactable = false;
        level09Btn.interactable = false;
        levelBonusBtn.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    public void unlockAllLevel() //unlock all level
    {
        level02Btn.interactable = true;
        level03Btn.interactable = true;
        level04Btn.interactable = true;
        level05Btn.interactable = true;
        level06Btn.interactable = true;
        level07Btn.interactable = true;
        level08Btn.interactable = true;
        level09Btn.interactable = true;
        levelBonusBtn.interactable = true;
        PlayerPrefs.SetInt("LevelPassed", 9);
    }

    public void debugButton()
    {
        Debug.Log(PlayerPrefs.GetInt("LevelPassed"));
        //PlayerPrefs.SetInt("LevelPassed", 7);
    }

}
