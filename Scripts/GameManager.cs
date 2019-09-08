using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject endGameUI;
    public Text activeScore;
    public Text finalScore;

    public void endGame()
    {

        endGameUI.SetActive(true);
        activeScore.gameObject.SetActive(false);
        finalScore.text = "Score :  " + activeScore.text;
    }

    public void restartGame()
    {
       
        SceneManager.LoadScene(0);
    }
}
