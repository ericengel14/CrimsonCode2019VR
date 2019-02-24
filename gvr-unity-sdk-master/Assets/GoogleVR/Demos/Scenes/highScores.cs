using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScores : MonoBehaviour
{

    public Text highScoreText;
    public static User user = new User();
    public static int playerScore;
    public static string playerName;
    public static int currentScore = 150;

    // Start is called before the first frame update
    void Start()
    {
        RestClient.Get<User>(url: "https://daydream-b0bf1.firebaseio.com/highScore.json").Then(onResolved: response =>
        {
            user = response;
            updateScore();
        });
        user.userName = "High Score";

    }

    void updateScore()
    {
        highScoreText.text = "High Score: " + user.userScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void end()
    {
        if (currentScore > user.userScore)
        {
            user.userScore = currentScore;

            RestClient.Put(url: "https://daydream-b0bf1.firebaseio.com/highScore.json", user);
        }
    }
}
