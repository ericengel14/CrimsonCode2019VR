using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static int timeLeft = 150;
    public static bool youWinB = false;
    public Text countdownText;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);

        if(timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
        }

        if (youWinB)
        {
            countdownText.text = "YOU WIN!!!!";
        }
    }

    public static void youWin()
    {
        youWinB = true;
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
