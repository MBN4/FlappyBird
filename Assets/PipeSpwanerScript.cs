using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpwanerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spwanRate = 4;
    private float timer = 0;
    public float heightOfSet = 10;


    // Start is called before the first frame update
    void Start()
    {
        spwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spwanPipe();
            timer = 0;
        }
    }
    void spwanPipe() {

        float lowestPoint = transform.position.y - heightOfSet;
        float highestPoint = transform.position.y + heightOfSet;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
