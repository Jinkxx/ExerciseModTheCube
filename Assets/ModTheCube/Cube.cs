using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;    
    float rotationSpeed;
    void Start()
    {
        rotationSpeed = Random.Range(1.5f, 15.0f);
        //position xyz
        transform.position = new Vector3(3, 5, 1);
        //size
        transform.localScale = Vector3.one * 1.9f;
    }
    
    void Update()
    {
        transform.Rotate(0.0f,10.0f * Time.deltaTime * rotationSpeed, 0.0f);
        //change color over time using unitys time.time
        //rgba color, remember a controls opacity, 0 is fully transparent, 1 is fully opaque
        Material material = Renderer.material;
        float r = Mathf.PingPong(Time.time * 0.5f, 1.0f);
        float g = Mathf.PingPong(Time.time * 0.3f, 1.0f);
        float b = Mathf.PingPong(Time.time * 0.7f, 1.0f);
        float a = Mathf.PingPong(Time.time * 0.2f, 1.0f);
        material.color = new Color(r, g, b, a);
    }
}
