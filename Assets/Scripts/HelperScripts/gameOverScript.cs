using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class gameOverScript : MonoBehaviour
{

    public GameObject levelselection;
    public GameObject GameOverPanel;
    void Start()
    {
       GameOverPanel.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        GameOverPanel.SetActive(true);
       

    }
    public void MainMenu()
    {
        levelselection.SetActive(true);
    }
   
    


}
