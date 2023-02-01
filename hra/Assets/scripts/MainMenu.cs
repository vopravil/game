using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
   
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
        outOfBorder.tankSurvive = 0;
        detectCollision.score = 0;
    }
}
