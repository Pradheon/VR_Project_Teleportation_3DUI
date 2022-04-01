using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrane : MonoBehaviour
{
    [SerializeField] float speed; //0
    [SerializeField] Transform upperLimit;
    [SerializeField] Transform lowerLimit;
    [SerializeField] Transform from;
    [SerializeField] Transform to;
    [SerializeField] GameObject sphere;

    float direction = 0;

    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        if (direction == -1 && transform.position.y > lowerLimit.position.y)
        {
            Debug.Log("Going down " + transform.position.y);
            transform.position = Vector3.MoveTowards(transform.position, lowerLimit.position, step);
            if (Mathf.Approximately(transform.position.y, lowerLimit.position.y))
            {
                direction = 0;
                sphere.transform.parent = transform.transform;
            }
        }
        else if (direction == 1 && transform.position.y < upperLimit.position.y)
        {
            Debug.Log("Going up " + transform.position.y);
            transform.position = Vector3.MoveTowards(transform.position, upperLimit.position, step);
            if (Mathf.Approximately(transform.position.y, upperLimit.position.y))
            {
                direction = 0;
            }
        }

        /*
        if (direction == -1 && transform.position.x > from.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, from.position, step);
            if (Mathf.Approximately(transform.position.x, from.position.x))
            {
                direction = 0;
            }
            else if (direction == 1 && transform.position.x < to.position.x)
            {

            }
        }
        */
    }

    public void RedButtonPressed()
    {
        direction = -1;
    }
    public void RedButtonReleased()
    {
        //direction = 0;
    }

    public void BlueButtonPressed()
    {
        direction = 1;
    }
    public void BlueButtonReleased()
    {
        //direction = 0;
    }

    public void GreenButtonPressed()
    {
        direction = 1;
    }
}
