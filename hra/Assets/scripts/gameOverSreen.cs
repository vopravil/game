using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameOverSreen : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI winText;

    // Start is called before the first frame update
    public void Setup(int score)
    {
        GameObject.Find("ButtonOpenGamePanel").SetActive(false);
        gameObject.SetActive(true);
        text.text ="score: " +score;
        NewHightScore();
    }
    public void Win()
    {
        GameObject.Find("ButtonOpenGamePanel").SetActive(false);
        gameObject.SetActive(true);
        text.text = "score: " + detectCollision.score;
        winText.text = "invaders are defeated";
        NewHightScore();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
        outOfBorder.tankSurvive = 0;
        detectCollision.score = 0;
        fireMissile.pomocna = 0;
    }
    public void ExitButton()
    {
        
        SceneManager.LoadScene("Menu");
    


    }
    public void NewHightScore()
    {
        if (detectCollision.score >0 && detectCollision.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", detectCollision.score);
        }
        
    }

}
