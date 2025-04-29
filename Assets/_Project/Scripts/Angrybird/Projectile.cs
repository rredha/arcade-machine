using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D Rb {get; private set;}
    public Collider2D Col {get; private set;}

    private void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
        Col = GetComponent<Collider2D>();
    }

    public void SetProjectileStatic()
    {
        Col.enabled = false; 
        Rb.isKinematic = true;
    }
    public void SetProjectileDynamic()
    {
        Col.enabled = true; 
        Rb.isKinematic = false;
    }
}
