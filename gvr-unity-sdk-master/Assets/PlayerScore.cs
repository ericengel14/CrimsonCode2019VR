using Proyecto26;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text scoreText;
    public InputField nameText;

    private System.Random random = new System.Random();
    User user = new User();
    public static int playerScore;
    public static string playerName;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = random.Next(0, 100);
        scoreText.text = "Score: " + playerScore;
    }

    public void OnSubmit()
    {
        playerName = nameText.text;
        postToDatabase();
    }

    public void OnGetScore()
    {
        retrieveFromDatabase();
    }

    private void postToDatabase()
    {
        User user = new User();
        RestClient.Put( url: "https://daydream-b0bf1.firebaseio.com/" + playerName + ".json", user);
    }

    private void updateScore()
    {
        scoreText.text = "Score: " + user.userScore;
    }

    private void retrieveFromDatabase()
    {
        RestClient.Get<User>(url: "https://daydream-b0bf1.firebaseio.com/" + nameText.text + ".json").Then(onResolved: response =>
        {
            user = response;
            updateScore();
        });
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
