using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float movespeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < -30)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
        transform.position = transform.position + Vector3.left * movespeed * Time.deltaTime;
    }

}
