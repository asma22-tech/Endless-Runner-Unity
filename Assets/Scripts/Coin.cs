using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationspeed = 90f;
    public float speed = 1f;
    public AudioClip coinSound;


    private void OnTriggerEnter(Collider other)
    {
        //the coin only coilds with the player
        if (other.gameObject.name == "Player")
        {
            GameManager.totalscore+=1;
            AudioSource.PlayClipAtPoint(coinSound,transform.position,0.5f);
            Destroy(gameObject);
        }
    }

    
 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,rotationspeed*Time.deltaTime);
        transform.position = new Vector3( transform.position.x,Mathf.PingPong(Time.time * speed, 3), transform.position.z);
        Destroy(gameObject,3);
        
        
    }

    

}
