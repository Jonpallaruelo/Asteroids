using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTime : MonoBehaviour
{
    public float destroyTime = 5.0f;
    void Start()
    {
        Destroy(gameObject,destroyTime); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
