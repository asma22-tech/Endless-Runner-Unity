using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    
    public GameObject coins;
    public Vector3 spawmValues;
    public float spawmWait;
    public float spawmMostWait;
    public float spawmLeastWait;
    public int startWait;
    bool stop;
    public int coinsMax;
    float speed = 10;
    int coinsSpawned = 0;
    
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(waitSpawmer());
    }

    // Update is called once per frame
    void Update()
    {
        
        spawmWait = Random.Range(spawmLeastWait, spawmMostWait);
       if (coinsMax <= coinsSpawned)
            {
            stop = true;
            }
        else
        {
             stop = false;
        }

        }
    IEnumerator waitSpawmer()
    {

        yield return new WaitForSeconds(startWait);
     
        while (!stop)
        {
            
            Vector3 spawnPosition = new Vector3(Random.Range(-spawmValues.x, spawmValues.x), 1, Random.Range(-spawmValues.z, spawmValues.z));
            Instantiate(coins, spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawmWait);
            
        }
    }
}

