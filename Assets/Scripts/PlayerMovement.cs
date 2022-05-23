using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public static int playerINblock = 0;
    public static bool isAlive = true;

    
    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetButton("Fire1"))
        {
            this.transform.position += Camera.main.transform.forward * speed * Time.deltaTime;
        }
    }
}

