using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        //position xyz
        transform.position = new Vector3(3, 5, 1);
        //size
        transform.localScale = Vector3.one * 1.9f;
        
        Material material = Renderer.material;
        //rgba color
        material.color = new Color(2.6f, 1.4f, 0.6f, 0.3f);
    }
    
    void Update()
    {
        transform.Rotate(0.0f,10.0f * Time.deltaTime * 10, 0.0f);
    }
}
