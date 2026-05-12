using UnityEngine;
using TMPro;

public class RedScoreUpdate : MonoBehaviour
{
    public int red_score = 0;
    public TMP_Text scoreText;
    public TMP_Text winScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // If the ball collides with the yellow goal it will increase red's score
        if (other.gameObject.name == "Ball")
        {
            red_score += 1;
        }
        UpdateScore();
    }
    // Update is called once per frame
    void UpdateScore()
    {
        // Prints if red wins
       scoreText.text = red_score.ToString();

       if(red_score == 5)
       {
        winScreen.text = "Red Wins!";

        Time.timeScale = 0f;
       }
    }
}
