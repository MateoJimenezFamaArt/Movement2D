using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs : MonoBehaviour
{
    private Movement Moviendosaurio;
    private Charactermovement Culiacan;
    public Charactermovement.GroundActions Botonacio;

   private void OnEnable()
    {
        Botonacio.Enable();
    }

    private void OnDisable()
    {
        Botonacio.Disable();

    }

    // Start is called before the first frame update
    void Awake ()
        
    {
        Moviendosaurio = GetComponent<Movement>();
        Culiacan = new Charactermovement();
        Botonacio = Culiacan.Ground;
        Botonacio.Jump.performed += ctx => Moviendosaurio.Piernitas(); 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Moviendosaurio.Cerebrito(Botonacio.Move.ReadValue<Vector2>()); 
    }

 

}


