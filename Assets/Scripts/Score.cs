using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private double score;
    private double POINTS;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        POINTS = 10;
        Debug.Log(string.Format("Starting score: {0}. " +
            "Each time you hit the target you will get {1} points", score, POINTS));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected");
        if (collision.gameObject.name == "ObjectToThrow")
        {
            score += POINTS;
            Debug.Log(string.Format("The Object hit the target. Current score: {0}", score));
        }
    }
}
