using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour

// Used to load the game after pressing the start button
{
    public string LevelName;

    public void LoadLevel()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(LevelName);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
