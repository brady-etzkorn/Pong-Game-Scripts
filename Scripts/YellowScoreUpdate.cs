using UnityEngine;
using TMPro;

public class YellowScoreUpdate : MonoBehaviour
{
    public int yellow_score = 0;
    public TMP_Text scoreText;
    public TMP_Text winScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        // If the ball collides with the red goal it will increase yellow's score
        if (other.gameObject.name == "Ball")
        {
            yellow_score += 1;
        }
        UpdateScore();
    }
    // Update is called once per frame
    void UpdateScore()
    {
        // Prints if yellow wins
       scoreText.text = yellow_score.ToString();

       if(yellow_score == 5)
       {
        winScreen.text = "Yellow Wins!";

        Time.timeScale = 0f;
        
       }
    }
}
