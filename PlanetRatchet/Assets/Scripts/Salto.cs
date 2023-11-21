using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    Rigidbody rb;
    bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = Vector3.down;
        // Vecto3.down
        RaycastHit col;
        if (Physics.Raycast(origen, direccion, out col, 0.5f))
        {


            isGrounded = true;

        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //Invoke("Jump", 3f);
            Jump();
        }
    }
    void Jump()
    {

        rb.AddForce(Vector3.up * 300);
        isGrounded = false;
    }

    private void OnDrawGizmos()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = -transform.up;
        Gizmos.color = Color.green;
        Gizmos.DrawRay(origen, direccion);

        Vector3 direccionMundo = Vector3.down;
        Gizmos.color = Color.red;
        Gizmos.DrawRay(origen, direccionMundo);
    }
}
