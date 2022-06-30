using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody rb;
    public Transform spavnPosithion;
    public float throwForce;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Rigidbody spavn;
            spavn = Instantiate(rb, spavnPosithion.position, spavnPosithion.rotation) as Rigidbody;
            spavn.AddForce(spavnPosithion.forward * throwForce * 10);

           
           
        }
        

    }

    
    
}