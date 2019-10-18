using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    //   GameObject mypaddle;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {


        float xPoint = Input.mousePosition.x;
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(xPoint, 0, 0)) - new Vector3(0,-1,Camera.main.transform.position.z); //+ (0,transform.position.x, transform.position.y);

    }
}
