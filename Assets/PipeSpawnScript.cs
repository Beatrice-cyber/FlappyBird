using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    private float timer =0;
    private float SpawnRate= 2;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        
        MakePipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            MakePipes();
            timer = 0;
        }
        

        
    }
    void MakePipes()
    {
        float lowestpt = transform.position.y - heightOffset;
        float highestpt = transform.position.y + heightOffset;
        GameObject pipeClone = Instantiate(pipe, new Vector3(transform.position.x,
            Random.Range(lowestpt,highestpt),
            0),transform.rotation);
    }
    
        
    

}
