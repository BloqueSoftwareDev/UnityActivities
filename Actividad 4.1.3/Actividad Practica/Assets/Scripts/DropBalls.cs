using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBalls : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] Vector2 limits;
    [SerializeField] float delay;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Dropper", 1, delay);
    }

    void Dropper()
    {
        position = new Vector3(Random.Range(-limits.x, limits.x), Random.Range(limits.y-(limits.y/2), limits.y+(limits.y/2)), 0);
        Instantiate(ball, position, Quaternion.identity);
    }
}
