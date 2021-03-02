using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalAuto : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float limit;
    [SerializeField] float speed;
    Vector3 motion;
    float direction = 1;
    bool goingRight = true;
    [SerializeField] SpriteRenderer sprite;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > limit && goingRight)
        {
            direction = -1;
            goingRight = false;
            sprite.flipX = true;
        }
        if(transform.position.x < -limit && !goingRight)
        {
            direction = 1;
            goingRight = true;
            sprite.flipX = false;
        }
        motion.x = direction;
        transform.position = transform.position + motion * speed;
    }
}
