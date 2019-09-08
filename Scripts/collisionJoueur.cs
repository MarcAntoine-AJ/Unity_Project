using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionJoueur : MonoBehaviour
{
    // Start is called before the first frame update

 public  Déplacement déplacement;
    public GameManager gameManager;
    private void OnCollisionEnter(Collision collision)
       

    {
      
        if(collision.collider.tag== "Obstacle")
        {
            
            déplacement.enabled = false;
            gameManager.endGame();

        }
    }
}
