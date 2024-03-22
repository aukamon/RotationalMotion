using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testInertia : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(this.name + "Inertia is :"+ rb.inertiaTensor);
        rb.angularVelocity = rb.inertiaTensor;
        transform.localScale += new Vector3(Input.GetAxis("Horizontal"),0,0);
    }
}
