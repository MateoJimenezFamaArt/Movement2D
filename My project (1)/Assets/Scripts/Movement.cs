using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D Mecantaelculo;
    private Vector3 Vectoristo;
    [SerializeField] private float Elsaltico;
    [SerializeField] private float Elpiquesito;
    [SerializeField] private float Lajaladita = -9.8f;
    [SerializeField] private bool Lustrarbaldosa;
    [SerializeField] Collider2D floor_;
    public void Cerebrito(Vector2 Vicotrelvector)
    {
        Vector3 Elprimodevictor = Vector3.zero;
        Elprimodevictor.x = Vicotrelvector.x;
        Elprimodevictor.y = Vicotrelvector.y;

        Mecantaelculo.velocity = ((transform.TransformDirection(Elprimodevictor) * Elpiquesito)+ Vectoristo) * Time.deltaTime;
        Vectoristo.y += Lajaladita * Time.deltaTime;
        Mecantaelculo.velocity = Vectoristo * Time.deltaTime;




        //Si se me ilumina el jopo quito el if
        if (Lustrarbaldosa && Vectoristo.y < 0f)
        {
            Vectoristo.y = -1;
        }


    }

    public void Piernitas()
    {
        if (Lustrarbaldosa)
        {
            Debug.Log("Oiga");
            Vectoristo.y = Mathf.Sqrt(Elsaltico * -1 * Lajaladita);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        Mecantaelculo = GetComponent<Rigidbody2D>();   
    }
 
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("Floor"))
        {
            Lustrarbaldosa = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Lustrarbaldosa = false;
    }
}
