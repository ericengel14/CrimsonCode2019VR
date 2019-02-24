using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float distance = 15;
    public bool movement = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GvrControllerInput.ClickButtonDown)
        {
            movement = true;
        }

        if(GvrControllerInput.ClickButtonUp)
        {
            movement = false;
        }

        if (movement)
        {
            transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
        }
    }
}
