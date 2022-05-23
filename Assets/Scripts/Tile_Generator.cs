using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_Generator : MonoBehaviour
{
    public List<GameObject> Blocks; // we have 3 elements in the list - 0,1,2
    int RandomBlock, nxtBlock;

   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("playerINblock=" + PlayerMovement.playerINblock);
        //Debug.Log("Block_capacity="+ Blocks.Capacity);

        if (PlayerMovement.playerINblock == Blocks.Capacity-1) //if player in the last element (i.e. 2) of the list 
        {
            RandomBlock = Random.Range(0, Blocks.Capacity-1); //Since we 3 elements(i.e. 0,1,2) in the list ,we generate random number between 0 and 1 
        }
        
        else // if Player is not the last element of the list , we generate random number between (PlayerMovement.playerINblock + 1, Blocks.Capacity)
        {
            RandomBlock = Random.Range(PlayerMovement.playerINblock + 1, Blocks.Capacity); // +1 to avoid repeating of same tile
        }
        
        nxtBlock = RandomBlock;
        Blocks[nxtBlock].transform.position = new Vector3(0, 0, Blocks[PlayerMovement.playerINblock].transform.position.z + 240); // 240 is pathlenght
        PlayerMovement.playerINblock = RandomBlock; //in which block player is
       
        Debug.Log("RandomBlock=" + RandomBlock);     
    }
    

}
