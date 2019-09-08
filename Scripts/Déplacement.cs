using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Déplacement : MonoBehaviour
{

    public Rigidbody rigidBody;
    private List<KeyCode> listeKeys = new List<KeyCode>();
    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;
    public float upwardsForce = 2000f;
    private Boolean isJumping = false;
    public GameManager gameManager;
    // Update is called once per frame
    void Update() 
    {
        getKeys();
        vérifierJump();
        traiterKeys();
        if(this.transform.position.y < 0)
        {
            gameManager.endGame(); ;
                
                }
    }

    private void vérifierJump()
    {
       if(transform.position.y < 1.1)
        {
            isJumping = false;

        }else
        {
            isJumping = true;
        }
    }

    private void traiterKeys()
    {
        if (listeKeys.Contains(KeyCode.UpArrow))
        {
      
            rigidBody.AddForce(forwardForce * Time.deltaTime, 0, 0);
        }


        if (listeKeys.Contains(KeyCode.DownArrow))
        {
            rigidBody.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }


        if (listeKeys.Contains(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(0,  0,sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (listeKeys.Contains(KeyCode.RightArrow))
        {
            rigidBody.AddForce(0, 0, -sidewaysForce * Time.deltaTime,ForceMode.VelocityChange);
        }

        if (listeKeys.Contains(KeyCode.Space) && !isJumping)
        {
            rigidBody.AddForce(0, upwardsForce*Time.deltaTime, 0,ForceMode.VelocityChange);
        }
    }

    private void getKeys()
    {
        //   if(Input.GetKey(KeyCode.UpArrow))
        //      {
        //    if (!listeKeys.Contains(KeyCode.UpArrow))
        //    {
        //    listeKeys.Add(KeyCode.UpArrow);
        //  }
        //   }
        //    else
        //    {
        //    listeKeys.Remove(KeyCode.UpArrow);
        //   }


        //     if (Input.GetKey(KeyCode.DownArrow))
        //    {
        //     if (!listeKeys.Contains(KeyCode.DownArrow))
        //    {
        //        listeKeys.Add(KeyCode.DownArrow);
        //   }
        //    }
        //     else
        //    {
        //    listeKeys.Remove(KeyCode.DownArrow);
        //   }



        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!listeKeys.Contains(KeyCode.RightArrow))
            {
                listeKeys.Add(KeyCode.RightArrow);
            }
        }
        else
        {
            listeKeys.Remove(KeyCode.RightArrow);
        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (!listeKeys.Contains(KeyCode.LeftArrow))
            {
                listeKeys.Add(KeyCode.LeftArrow);
            }
        }
        else
        {
            listeKeys.Remove(KeyCode.LeftArrow);
        }



        if (Input.GetKey(KeyCode.Space))
        {
            if (!listeKeys.Contains(KeyCode.Space))
            {
                listeKeys.Add(KeyCode.Space);
            }
        }
        else
        {
            listeKeys.Remove(KeyCode.Space);
        }
    }
}
