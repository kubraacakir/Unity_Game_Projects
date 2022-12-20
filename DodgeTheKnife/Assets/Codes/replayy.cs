using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class replayy : MonoBehaviour
{
    
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        health.characterHealth = 3;
        Time.timeScale = 1;
    }
}
