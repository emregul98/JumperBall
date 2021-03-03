using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ball;
    public Admin admin;
    private Vector3 cameraPos;

    Vector3 new_coordinat;
    List<GameObject> cubes;
    void Awake()
    {
        new_coordinat = transform.position;
        cubes = new List<GameObject>();
        ball = FindObjectOfType<BallController>().transform;
        GameObject[] floors = GameObject.FindGameObjectsWithTag("red_cube");
        foreach (GameObject floor in floors)
        {
            cubes.Add(floor);
        }
        admin.totalCube = (float)cubes.Count;
    }


    void Update()
    {
        foreach (GameObject coordinat in cubes)
        {
            if (ball.position.y <= coordinat.transform.position.y)
            {
                admin.passcube();
                cubes.Remove(coordinat);
                new_coordinat = transform.position;
            }
            cameraPos = new Vector3(transform.position.x, ball.transform.position.y, transform.position.z);
            transform.position = new Vector3(transform.position.x, cameraPos.y+5, -18);
        }
    }
}
