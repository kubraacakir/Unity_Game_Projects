using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class health : MonoBehaviour
{
    public static int characterHealth = 3;
    public TextMeshProUGUI healthText;
    public GameObject gameOverPanel;
    void Start()
    {
        
    }

    
    void Update()
    {
        healthText.text = "Health:" + characterHealth.ToString();

        if(characterHealth == 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
