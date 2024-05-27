using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCube : MonoBehaviour
{

    [SerializeField]
    private int limit;
    [SerializeField]
    private int speed;
    [SerializeField]
    private int dir;

    private float trackX = 0;
    private float trackY = 0;



    private Vector3 Pos;

    // Start is called before the first frame update
    void Start()
    {
        Pos = transform.position;
        trackX = Pos.x;
        trackY = Pos.y;
    }

    // Update is called once per frame
    void Update()
    {
        Pos = transform.position;


        if (dir == 0)
        {
            Pos.x += speed * Time.deltaTime;

            if (Pos.x - trackX > limit)
            {
                dir = 1;
            }
        }
        else if(dir == 1)
        {
            Pos.y += speed * Time.deltaTime;

            if (Pos.y - trackY > limit)
            {
                dir = 2;
            }
        }
        else if( dir == 2)
        {
            Pos.x -= speed * Time.deltaTime;

            if (Pos.x - trackX < -limit)
            {
                dir = 3;
            }
        }
        else if (dir == 3)
        {
            Pos.y -= speed * Time.deltaTime;

            if (Pos.y - trackY < -limit)
            {
                dir = 0;
            }
        }

        transform.position = Pos;
    }
}
