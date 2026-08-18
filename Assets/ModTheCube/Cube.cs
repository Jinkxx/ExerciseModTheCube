using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;    
    float rotationSpeed;
    float changexyz;
    float changeSize;
    void Start()
    {

    }
    
    void Update()
    {
        transform.localScale = Vector3.one * changeSize;
        transform.position = new Vector3(changexyz, changexyz, changexyz);
        transform.Rotate(0.0f,10.0f * Time.deltaTime * rotationSpeed, 0.0f);
        //change color over time using unitys time.time
        //rgba color, remember a controls opacity, 0 is fully transparent, 1 is fully opaque
        Material material = Renderer.material;
        float r = Mathf.PingPong(Time.time * 0.5f, 1.0f);
        float g = Mathf.PingPong(Time.time * 0.3f, 1.0f);
        float b = Mathf.PingPong(Time.time * 0.7f, 1.0f);
        float a = Mathf.PingPong(Time.time * 0.2f, 1.0f);
        material.color = new Color(r, g, b, a);
        rotationSpeed = Mathf.PingPong(Time.time * 0.5f, 100.0f);
        changexyz = Mathf.PingPong(Time.time * 0.5f, 5.0f);
        changeSize = Mathf.PingPong(Time.time * 0.5f, 2.0f) + 0.5f;
        
    }
}
