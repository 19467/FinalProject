using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreKeeping : MonoBehaviour
{
    public static int score = 0;
    public static int score2 = 0;
    public Text scoreboard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        //if (sceneName == "SampleScene")
       // {
        scoreboard.text = score.ToString();
        //}
        //if (sceneName == "level2gameplay")
        //{
        //    scoreboard.text = score2.ToString();
        //}
    }
}
