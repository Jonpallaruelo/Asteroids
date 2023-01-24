using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneControl : MonoBehaviour
{

    public GameObject gameOver, levelFinished;
    public GameObject playership;
    public GameObject asteroid;
    public int gameOverScene, levelFinishedScene;
    private int Score = 0;
    public Text theScore;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        levelFinished.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == null)
        {
            SceneManager.LoadScene(gameOverScene);
        }

       else  if (playership== null)
        {
            gameOver.SetActive(true);
        }


        if (levelFinished == null)
        {

            SceneManager.LoadScene(levelFinishedScene);
        }
        else if (GameObject.FindGameObjectsWithTag("asteroid").Length == 0)
        {
            levelFinished.SetActive(true);
        }

        theScore.text = "Score "+Score;
    }


    public void IncreaseScore(int point)
    {


        Score += point;
    
    }


}

   
