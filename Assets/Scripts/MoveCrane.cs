using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrane : MonoBehaviour
{
    public float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveUp()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
    }
    public void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    public void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
    }

    public void MoveRight()
    {
        transform.Translate(-Vector3.right * Time.deltaTime);
    }
}
