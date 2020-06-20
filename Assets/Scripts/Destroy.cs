using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject diamond; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter( Collider other )
    {
        if (other.gameObject.tag == "Player") {
        Destroy(diamond,0f);
       }
    }
    
}
