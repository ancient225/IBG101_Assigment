using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField]
    private int speed;
    [SerializeField]
    private GameObject BellSound;
    [SerializeField]
    private Material[] materials = new Material[8];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += speed * Time.deltaTime;
        transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        speed *= -1;

        //Instantiate(BellSound, gameObject.transform);

        int ran = Random.Range(0, 8);
        GetComponent<MeshRenderer>().material = materials[ran];

        int ran2 = Random.Range(0, 8);
        if(other.transform.tag == "bell Wall")
        other.GetComponent<MeshRenderer>().material = materials[ran2];
    }
}
