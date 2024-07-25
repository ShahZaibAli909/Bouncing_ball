using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelActive : MonoBehaviour
{
    public GameObject[] levels ;
    public int lastLevel;
    public GameObject panel;

   void Start()
    {
        panel.SetActive(true);
    }
    public void LevelToActive(int newLevel)
    {
        levels[lastLevel].SetActive(false);
        levels[newLevel].SetActive(true);
        panel.SetActive(false);
        lastLevel = newLevel;
    }
    public void RestartLevel()
    {
        //levels[lastLevel].SetActive(true);
        
    }
}

