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

    float directionY = 0;
    float directionX = 0;
    bool attached;

    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move

        // Y-Direction Movement
        if (directionY == -1 && transform.position.y > lowerLimit.position.y)
        {
            Debug.Log("Going down " + transform.position.y);
            transform.position = Vector3.MoveTowards(transform.position, lowerLimit.position, step);
            if (Mathf.Approximately(transform.position.y, lowerLimit.position.y))
            {
                directionY = 0;
                sphere.transform.parent = transform.transform;
                sphere.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        else if (directionY == 1 && transform.position.y < upperLimit.position.y)
        {
            Debug.Log("Going up " + transform.position.y);
            transform.position = Vector3.MoveTowards(transform.position, upperLimit.position, step);
            if (Mathf.Approximately(transform.position.y, upperLimit.position.y))
            {
                directionY = 0;
            }
        }

        // X-Direction Movement
        if (directionX == -1 && transform.position.x > from.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, from.position, step);
            if (Mathf.Approximately(transform.position.x, from.position.x))
            {
                directionX = 0;
            }
        }
        else if (directionX == 1 && transform.position.x < to.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, to.position, step);
            if (Mathf.Approximately(transform.position.x, to.position.x))
            {
                directionX = 0;
            }
        }
    }

    public void RedButtonPressed()
    {
        directionY = -1;
    }
    public void RedButtonReleased()
    {
        //directionY = 0;
    }

    public void BlueButtonPressed()
    {
        directionY = 1;
    }
    public void BlueButtonReleased()
    {
        //directionY = 0;
    }

    public void GreenButtonPressed()
    {
        directionX = 1;
    }

    public void GreenButtonReleased()
    {
        //directionX = 1;
    }

    public void PinkButtonPressed()
    {
        directionX = -1;
    }

    public void PinkButtonReleased()
    {
        //directionX = 1;
    }

    public void YellowButtonPressed()
    {
        transform.parent = null;
        sphere.GetComponent<Rigidbody>().isKinematic = false;
        sphere.GetComponent<Rigidbody>().detectCollisions = true;
    }

    public void YellowButtonReleased()
    {
        //does nothing
    }
}
