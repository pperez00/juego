using UnityEngine;

public class MovimientoBola : MonoBehaviour
{
    public Rigidbody bola;
    public float fuerzaAdelante = 800f;
    public float fuerzaLado = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        bola.AddForce(0, 0, fuerzaAdelante * Time.deltaTime);

        if (Input.GetKey("right"))
        {
            bola.AddForce(fuerzaLado * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("left"))
        {
            bola.AddForce(-fuerzaLado * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
