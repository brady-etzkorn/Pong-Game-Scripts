using UnityEngine;
using UnityEngine.UI;

public class ShowBacktoMenu : MonoBehaviour
{
    public Button BackButton;

    public YellowScoreUpdate yellowScore;
    public RedScoreUpdate redScore; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BackButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Shows the button when the score reaches a certain number
        if (yellowScore.yellow_score >= 5 || redScore.red_score >= 5)
        {
           BackButton.gameObject.SetActive(true);
        }
    }
}
