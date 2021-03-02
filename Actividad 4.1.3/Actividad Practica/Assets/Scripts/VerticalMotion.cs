using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMotion : MonoBehaviour
{
    Vector3 motion;

    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        motion.y = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + motion*speed;
    }
}
