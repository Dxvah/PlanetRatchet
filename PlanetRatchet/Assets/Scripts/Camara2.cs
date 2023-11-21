using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Camara2 : MonoBehaviour
{
    public GameObject cubo;
    private Vector3 offsetCamara;
    private Vector3 rotar;

    public float offSetY, offSetZ;
    private float x, y;
    public float Suavizado;
    public float sensibilidad = 1f;
    
    

    private void Start()
    {
        transform.position = new Vector3(cubo.transform.position.x, cubo.transform.position.y + offSetY, cubo.transform.position.z - offSetZ);
        offsetCamara = transform.position - cubo.transform.position;
    }
    void Update()
    {
            //camara primera persona.
            transform.position = cubo.transform.position;
            y = 5 * -Input.GetAxis("Mouse X");
            x = 5 * Input.GetAxis("Mouse Y");
            rotar = new Vector3(x * sensibilidad, y * sensibilidad, 0f);
            transform.eulerAngles = transform.eulerAngles - rotar;
    }
}

