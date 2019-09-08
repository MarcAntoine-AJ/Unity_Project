using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class déplacementSol : MonoBehaviour
{
    public Transform transformPlancher2;
    private Vector3 positionX;
    public float positionMaxInitiale = 120f;
    private float vitesseSol=50;
    public float scaleX = 5.95f;
   
    // Start is called before the first frame update
    private void Start()
    {
         positionX = new Vector3(this.transform.position.x,this.transform.position.y, this.transform.position.z);
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        positionX.x = positionX.x - vitesseSol * Time.deltaTime ;
         this.transform.position = positionX;
        if (positionX.x<= -40)
        {
            positionX = new Vector3(positionMaxInitiale,0,0);
        }
       
    }
}
