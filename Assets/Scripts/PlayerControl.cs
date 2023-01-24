using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float rotSpeed = 180f;
    public float yspeed = 8.0f;
    public float playerRot;
    public GameObject explosion;
    public GameObject[] myCannons;
    
    void Start()
    {
        playerRot = transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        playerRot -= Input.GetAxis("Horizontal") * Time.deltaTime * rotSpeed;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, playerRot);
        transform.position += transform.up * Input.GetAxis("Vertical") * yspeed * Time.deltaTime;
    }

    public void ChangeCannon(int theCannon)
    {
        foreach (GameObject currentCannon in myCannons)
        {
            currentCannon.SetActive(false);
        }

        myCannons[theCannon].SetActive(true);
    
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "asteroid")

        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
       
    }
}
