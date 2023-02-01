using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedText : MonoBehaviour
{
    public TextMeshProUGUI speedText;
    // Start is called before the first frame update
    void Start()
    {
        speedText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "SPEED: " + GameObject.Find("player").GetComponent<playerMovement>().moveSpeed;
    }
}
