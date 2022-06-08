using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIHandler: MonoBehaviour
{
    private GameManager gameManager;
    private TextMeshProUGUI text;
    private void Start()
    {
        gameManager = GameManager.Instance;
        text = transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore()
    {
        text.SetText(gameManager.Score.ToString());
    }
}
