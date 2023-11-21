using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlaneta : MonoBehaviour
{
    public float movX;
    public float movZ;
    Rigidbody rb;

    Vector3 gravedad;


    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
         gravedad = -transform.up * 9.81f;

        GetComponent<Rigidbody>().AddForce(gravedad, ForceMode.Force);
    }
    private void FixedUpdate()
    {

        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movX * 2, rb.velocity.y, movZ * 2);
        rb.velocity = movimiento;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, -transform.up);
    }
}
