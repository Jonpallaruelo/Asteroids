using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failship : MonoBehaviour
{
    public float xPost;
    public float yPost;
    public bool randonspeed;
    public float xSpeed=5.0f;
    public float ySpeed=5.0f;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        xPost = transform.position.x;
        yPost = transform.position.y;

        if (randonspeed == true)
        {
            xSpeed = Random.Range(-xSpeed,xSpeed);
            ySpeed = Random.Range(-ySpeed, ySpeed);
        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        xPost = xSpeed * Time.deltaTime;
        yPost = ySpeed * Time.deltaTime;
        yPost = ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPost, yPost, 0.0f);
    }
}
