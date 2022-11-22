using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float straightSpeed=0.5f;
    private float rotationalSpeed=0.2f;
    private float mousePosition;
    private float InputSpeed;

    void Update()
    {
        GoStraight();
        GoRotational();
    }

    private void GoStraight()
    {
        gameObject.transform.Translate(gameObject.transform.forward*Time.deltaTime*straightSpeed);
    }

    private void GoRotational()
    {
        if (Input.GetMouseButtonDown(0))
        {

            mousePosition = Input.mousePosition.x;
            InputSpeed = rotationalSpeed;


        }
        else if (Input.GetMouseButton(0))
        {
            float tranfeNum = Input.mousePosition.x - mousePosition;
            float x = tranfeNum * Time.deltaTime * InputSpeed;
            if (transform.position.x + x < isInRightEdge() && transform.position.x + x > isInLeftEdge())
            {
                transform.Translate(x, 0f, 0f);
                mousePosition = Input.mousePosition.x;
            }

        }
        else if (Input.GetMouseButtonUp(0))
        {
            InputSpeed = 0;

        }
    }

    private float isInRightEdge()
    {
        return -1.90f;
        
    }
    private float isInLeftEdge()
    {
        return -2.36f;

    }
}
