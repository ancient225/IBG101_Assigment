using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private float t;
    private Material mat;
    [SerializeField]
    private Material[] materials = new Material[8];

    // Start is called before the first frame update
    void Start()
    {
        t = 0;

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if( t > 2 )
        {
            int ran = Random.Range( 0, 8 );
            GetComponent<MeshRenderer>().material = materials[ran];
            t = 0;
        }
    }
}
