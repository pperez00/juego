using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public MovimientoBola movimiento;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstaculo")
        {
            movimiento.enabled = false;
        }
    }
}
