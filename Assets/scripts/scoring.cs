using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

public class scoring : MonoBehaviour
{
    public TMP_Text score;
    public int points;
    public GameObject rect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + points;
    }
    void OnTriggerEnter2D(Collider2D rect)
    {
        if(rect.gameObject.CompareTag("ball"))
        {
            points++;
            score.text = "Score: " + points;
            
        }
    }
}
