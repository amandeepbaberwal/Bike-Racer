using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    [SerializeField]
    private float speed = 30;
    [SerializeField]
    private float turnSpeed = 20;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate(turnSpeed * Vector3.right * Time.deltaTime);
            transform.Rotate(turnSpeed * Vector3.up * Time.deltaTime, 1.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate(turnSpeed * Vector3.left * Time.deltaTime);
            transform.Rotate(turnSpeed * Vector3.down * Time.deltaTime, 1.0f);
        }
    }
}
