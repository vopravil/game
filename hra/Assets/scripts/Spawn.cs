using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject tank;
    public float spawnTime = 10f;
    float positionX;
    float positionY;
    int[,] pole = new int[4, 4];
    int rnd;
    




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TankSpawn", 1f, spawnTime);



    }
    private void Update()
    {
        if (outOfBorder.tankSurvive == 3 || detectCollision.score == 100)
        {
            CancelInvoke();
        }
    }

    public void TankSpawn()
    {
        for (int i = 0; i < 4; i++)
        {
            rnd = Random.Range(0, 4);
            pole[i, rnd] = 1;

            

        }
       Dalsi();



        for (int j = 0; j < 4; j++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (pole[j, k] == 1)
                {
                    positionX = 32 + (9 * k);
                    positionY = -3.5f + (4 * j);
                    Instantiate(tank, new Vector2(positionX, positionY), transform.rotation);
                }
            }
        }
        for (int i = 0; i < pole.Length / 4; i++)
        {
            for (int j = 0; j < pole.Length / 4; j++)
            {
                pole[i, j] = 0;
            }
        }

    }

    public void Dalsi()
    {
        int pomocna = 0;
        int rndX;
        int rndY;
        int pomocna2 = detectCollision.score / 10;
        for (int i = 0; i < pomocna2; i++)
        {
            pomocna = 0;
            do
            {
                rndX = Random.Range(0, 4);
                rndY = Random.Range(0, 4);

                if (pole[rndX, rndY] == 0)
                {
                    pole[rndX, rndY] = 1;
                    pomocna = 1;
                }


            } while (pomocna == 0);
        }
        
    }
   

}


