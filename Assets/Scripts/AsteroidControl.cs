using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidControl : MonoBehaviour
{
    public float xPost = 0f;
    public float yPost=-0f;
    public float xlimit=11.0f;
    public float ylimit = 7f;
    public bool asteroidBounds;
    public bool randonSpeed;
    public bool createChildren;
    public GameObject thechildren;
    public GameObject explosion;
    public int energy = 5;
    public int numberOfChildren;
    public int points = 50;


    public float xSpeed=0.1f, YSpeed=0.1f;
    void Start()
    {
        xPost = transform.position.x;
        yPost = transform.position.y;
        if (randonSpeed)
        {
            xSpeed = Random.Range(-xSpeed, xSpeed);
            YSpeed = Random.Range(-YSpeed, YSpeed);
        
        }
    }

   
    void Update()
    {
        xPost = xPost + xSpeed * Time.deltaTime;
        yPost = yPost + YSpeed * Time.deltaTime;
        transform.position = new Vector3(xPost, yPost, 0);

        if (asteroidBounds == true)
        {
            BounceControl();
        }
        else LimitsControl();
      
    }

    void LimitsControl() 
    {



        if (xPost > xlimit)
        {

            xPost = -xlimit;

        }
        else if (xPost < -xlimit)
        {
            xPost = xlimit;
        }

        if (yPost > ylimit)
        {

            yPost = -ylimit;

        }
        else if (yPost < -ylimit)
        {
            yPost = xlimit;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playerbullet")
        {
            energy--;
            
        }

        if (energy <= 0)
        {
            if (createChildren == true)
            {
                for(int i = 0; i < numberOfChildren; i++) 
                {

                    Instantiate(thechildren, transform.position, transform.rotation);
                }

                
            }
            
            
            
            Instantiate(explosion, transform.position, transform.rotation);
            GameObject.Find("SceneControl").SendMessage("IncreaseScore", points);
            Destroy(gameObject);
        }
    }

    void BounceControl()
    {
        if (xPost > xlimit)
        {

            xSpeed = -Mathf.Abs(xSpeed);
        }
        if (xPost <- xlimit) xSpeed = Mathf.Abs(xSpeed);

        /*if (yPost > ylimit)
        {
            if (YSpeed > 0.0f)
            {
                YSpeed = -YSpeed;
            }
        }
        if (yPost < -ylimit)
        {
            if (YSpeed < 0.0f)
            {
                YSpeed = -YSpeed;
            }
        
       
        }
        */
        if (yPost > ylimit) YSpeed = -Mathf.Abs(YSpeed);
        if (yPost < -ylimit) YSpeed = Mathf.Abs(YSpeed);
    
    
    }
}
