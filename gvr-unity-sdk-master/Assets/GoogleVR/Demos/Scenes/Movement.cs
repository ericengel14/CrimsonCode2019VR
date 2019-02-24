using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float distance = 5;
    public bool movement = false;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 temp = transform.position;
        temp.y = 1;
        transform.position = temp;
    }

    // Update is called once per frame
    void Update()
    {
        if (GvrControllerInput.ClickButtonDown)
        {
            Vector3 temp = transform.position;
            temp.y = 1;
            transform.position = temp;
            movement = true;
        }

        if(GvrControllerInput.ClickButtonUp)
        {
            Vector3 temp = transform.position;
            temp.y = 1;
            transform.position = temp;
            movement = false;
        }

        if (movement)
        {
            transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
            Vector3 temp = transform.position;
            temp.y = 1;
            transform.position = temp;
        }
    }
}
