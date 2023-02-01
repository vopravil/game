using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGame : MonoBehaviour
{
    // Start is called before the first frame update
	public void stopGame()
    {
        Time.timeScale = 0;
    }
}
