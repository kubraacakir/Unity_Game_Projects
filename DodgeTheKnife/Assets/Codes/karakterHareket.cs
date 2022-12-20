using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterHareket : MonoBehaviour
{
    public float hareketHizi;


    void Start()
    {
        
    }

    
    void Update()
    {
        float hiz = hareketHizi * Input.GetAxis("Horizontal");
        transform.Translate(hiz * Time.deltaTime, 0, 0);
        float xPozisyon = Mathf.Clamp(transform.position.x, -8.15f, 8.15f);
        transform.position = new Vector2(xPozisyon, transform.position.y);
    }
}