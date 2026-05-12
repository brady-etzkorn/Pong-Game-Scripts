using UnityEngine;
using UnityEngine.UI;

public class ShowRestartButton : MonoBehaviour
{
    public Button RestartButton;

    public YellowScoreUpdate yellowScore;
    public RedScoreUpdate redScore; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RestartButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Shows the button when the score reaches a certain number
        if (yellowScore.yellow_score >= 5 || redScore.red_score >= 5)
        {
           RestartButton.gameObject.SetActive(true);
        }
    }
}
