using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touching : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D otherObjects)
    {
        Debug.Log("Pinball Touched: " + otherObjects.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D rect)
    {
        if(rect.gameObject.name == "GrayHole")
        {
            Debug.Log("The ball fell, game over!");
        }
        
    }
}
