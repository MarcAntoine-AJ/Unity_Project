using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private float time;
    public Text texte;
    // Update is called once per frame
    void Update()
    {
        time = Time.timeSinceLevelLoad;
        texte.text = time.ToString("0");
    }
}
