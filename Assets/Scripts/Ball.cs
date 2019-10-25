using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle mypaddle;
    [SerializeField] float xVelocity = 2f;
    [SerializeField] float yVelocity = 15f;


    Vector2 paddleToBallDistance;

    bool hasStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        paddleToBallDistance = this.transform.position - mypaddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (!hasStarted)
        {
            LockBalltoPaddle();
            LaunchOnMouseClick();
        }


    }


    void LockBalltoPaddle()
    {
        Vector2 mypaddleposition = new Vector2(mypaddle.transform.position.x, mypaddle.transform.position.y);

        this.transform.position = mypaddleposition + paddleToBallDistance;

    }


    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVelocity, yVelocity);
        }

    }




}
