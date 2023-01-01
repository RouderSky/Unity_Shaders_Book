using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.SetColor("_Color", Color.black);
        GetComponent<MeshRenderer>().sharedMaterial.SetColor("_Color", Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
