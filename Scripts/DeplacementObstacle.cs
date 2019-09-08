using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementObstacle : MonoBehaviour
{
    private Vector3 position;
    private float vitesse= 50;
    public Vector3 positionCaméra;
    
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        position.x = position.x - vitesse * Time.deltaTime;
        this.transform.position = position;
        if(transform.position.x <positionCaméra.x)
        {
            Destroy(gameObject);
        }

    }
}
