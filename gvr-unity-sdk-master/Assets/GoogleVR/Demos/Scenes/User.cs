using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User 
{
    public string userName;
    public int userScore;

    public User()
    {
        userName = highScores.playerName;
        userScore = highScores.playerScore;
    }
    
}
