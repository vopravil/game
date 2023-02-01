using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReloadTextChange : MonoBehaviour
{
    public TextMeshProUGUI reloadText;
    // Start is called before the first frame update
    void Start()
    {
        reloadText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        reloadText.text = "RELOAD: " + GameObject.Find("player").GetComponent<fireMissile>().attackRate;
    }
}
