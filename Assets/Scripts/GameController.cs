using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    // The Game Over Label in game
    public GameObject labelGameOver;
    // The text for the score
    public Text labelScore;

    public bool gameOver = false;
    // The speed of all scrolling object
    public float scrollSpeed = -1f;
    public int score = 0;

    void Awake()
    {
        // If there is no Game Controller
        if(instance == null)
        {
            // This is the Game Controller
            instance = this;
        } 
        else if(instance != this)
        {
            // Destroy because it's a duplicate
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    // Function to set the bird dead
    public void BirdDied()
    {
        gameOver = true;
        labelGameOver.SetActive(true);
    }

    public void BirdScored()
    {
        if(!gameOver)
        {
            score++;
            labelScore.text = "Score : " + score.ToString();
        }
    }
}
