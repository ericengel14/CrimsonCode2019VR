using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public Text cdText;


    // Start is called before the first frame update
    void Start()
    {
  
    }

    void OnTriggerEnter(Collider col)
    {
        highScores.currentScore = Timer.timeLeft;

        cdText.text = ("Your Score = " + highScores.currentScore);

        Timer.youWin();

        highScores.end();
        //if (col.gameObject.name == "Player")
        //{
        
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
