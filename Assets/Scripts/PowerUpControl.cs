using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpControl : MonoBehaviour
{
    public int myPowerup =1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playership")
        {
            collision.gameObject.SendMessage("ChangeCannon", myPowerup);
            Destroy(gameObject);
           
        }
    }
}
