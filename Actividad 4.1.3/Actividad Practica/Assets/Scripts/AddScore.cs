using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// gabriel dichi, ian seidman y javier corona

public class AddScore : MonoBehaviour
{
    // Start is called before the first frame update
    int score = 10;
    public Text points;
    void Start()
    {
        print("Score: " + score);

    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Finish")
        {
            score+= 20;
        }
        else if(col.tag == "Enemy")
        {
            if(score > 0)
            {
                score -= 1;
            }
        }
        print("Score: " + score);
    }

    void Update()
    {
        points.text = "score: " + score.ToString();
    }
}
