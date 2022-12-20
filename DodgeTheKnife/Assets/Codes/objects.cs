using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class objects : MonoBehaviour
{
    private static int skor;
    public TextMeshProUGUI skorYazisi,gameoverText;
    public AudioClip injuryS;
    public AudioClip deadS;
    void Start()
    {
        skor = 0;
    }
    void Update()
    {
        skorYazisi.text = skor.ToString();
        gameoverText.text = "GAME OVER! \n SKOR:" + skor.ToString();
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        float xPozisyonu = Random.Range(-6.6f, 8.26f);
        float yPozisyonu = Random.Range(6.30f, 10.5f);

        if(temas.gameObject.tag == "kontrolCubugu")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            skor += 10;
        }
        else if(temas.gameObject.tag == "Karakter")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            health.characterHealth--;
            if(health.characterHealth == 0)
            {
                AudioSource.PlayClipAtPoint(deadS, Camera.main.transform.position);
            }
            else
            {
                AudioSource.PlayClipAtPoint(injuryS, Camera.main.transform.position);
            }
        }
    }
}
