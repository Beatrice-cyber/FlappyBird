using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{   
    public Rigidbody2D rigidBody;
    public int flapStrength;
    private bool birdAlive = true;

    public GameLogic logicScript;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hey, not my fault");
        logicScript = GameObject.FindGameObjectWithTag("logic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive) {
            rigidBody.velocity = Vector2.up * flapStrength; }
        if(transform.position.y < -20)
        {
            birdAlive = false;
            logicScript.GameOver();
        }
                    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided!");
        logicScript.GameOver();
        birdAlive = false;
    }

}
