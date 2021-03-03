using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneController : MonoBehaviour
{
    float controller;
    float turning_speed = 200.0f;
    //Rigidbody rgb;
    private void Start()
    {
        //rgb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        controller = Input.GetAxis("Horizontal") * turning_speed * Time.deltaTime;
        transform.Rotate(0, controller, 0);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Stationary:
                    if (touch.position.x < Screen.width / 2)
                    {
                        controller += turning_speed * Time.deltaTime;
                        transform.Rotate(0, -controller, 0);
                    }
                    if (touch.position.x > Screen.width / 2)
                    {
                        controller += turning_speed * Time.deltaTime;
                        transform.Rotate(0, +controller, 0);
                    }
                    break;
                case TouchPhase.Ended:
                    transform.Rotate(0, 0, 0);
                    break;
            }
        }
    }
}