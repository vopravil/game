using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lives : MonoBehaviour
{
    public GameObject[] lifeCaount;
    private int hearts;
    private bool dead = false;
 
    public gameOverSreen gameOverSreen;
    public GameObject button;
    int pomocna = 100;
    

    public GameObject joystick;



    // Start is called before the first frame update
    void Start()
    {
        hearts = lifeCaount.Length;
    }
    void GameOver()
    {
        gameOverSreen.Setup(detectCollision.score);
      
        
    }
    void GameWin()
    {
        gameOverSreen.Win();
        button.SetActive(false);
        joystick.SetActive(false);
        GameObject.Find("player").GetComponent<playerMovement>().enabled = false;

        GameObject[] movingTankLeft = GameObject.FindGameObjectsWithTag("tank");
        foreach (GameObject tankLeft in movingTankLeft)
        {
            tankLeft.GetComponent<moveLeft>().enabled = false;

        }
    }


    // Update is called once per frame
    void Update()
    {

       


        if (detectCollision.score == pomocna)
        {
            GameWin();
            pomocna = 0;
           
        }

        if (dead == false)
        {
            Takedamage();
            if (hearts - outOfBorder.tankSurvive <= 0)
            {

                dead = true;
                Destroy(lifeCaount[0]);

                GameOver();

                button.SetActive(false);
                joystick.SetActive(false);
                GameObject.Find("player").GetComponent<playerMovement>().enabled = false;            
                GameObject[] movingTankLeft = GameObject.FindGameObjectsWithTag("tank");
                foreach (GameObject tankLeft in movingTankLeft)
                {
                    tankLeft.GetComponent<moveLeft>().enabled = false;

                }



            }
          
        }
        void Takedamage()
        {

            /*if (outOfBorder.tankSurvive == pomocna)
            {
                
                pomocna++;
            }*/
            /*for (int i = 0; i < outOfBorder.tankSurvive; i++)
            {
                Destroy(lifeCaount[hearts - outOfBorder.tankSurvive].gameObject);
            }*/

            switch (outOfBorder.tankSurvive)
            {
                case 1:
                  
                    lifeCaount[2].SetActive(false);
                    
                    break;

                case 2:
                  


                    lifeCaount[2].SetActive(false); lifeCaount[1].SetActive(false);
                    break;

                case 3:

                    lifeCaount[2].SetActive(false); lifeCaount[1].SetActive(false); lifeCaount[0].SetActive(false);
                   

                    break;



            }





        }
    }
}

