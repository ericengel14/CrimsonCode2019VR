﻿using System.Collections;
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

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider collision)
        {
            //if (collision.tag == "Player")
            //{
                cdText.text = ("You Win");
            //}
        }
    }
}
