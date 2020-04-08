/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    public PlayerMovementScript playerMove;
    

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "ObstacleTag")
        {
            playerMove.enabled = false;
            FindObjectOfType<GameManagerScript>().EndGame();
        }   
    }
}
