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

    private void postToDatabase()
    {
        User user = new User();
        RestClient.Post( url: "https://daydream-b0bf1.firebaseio.com/.json", user);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
