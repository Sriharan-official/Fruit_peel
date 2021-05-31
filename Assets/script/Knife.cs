using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private float movementspeed;

    private Rigidbody knifeRb;
    private Vector3 movementVector;
    private bool ismoving = false;
    public float hitdamage;
    public Melon melon;
    void Start()
    {
        knifeRb = GetComponent<Rigidbody>();
      
    }

    void Update()
    {
        ismoving = Input.GetMouseButton(0);

        if (ismoving)
            movementVector = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f) * movementspeed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        if(ismoving)
        {
            knifeRb.position += movementVector;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Colliders collider = collision.collider.GetComponent<Colliders>();
        if(collider != null)
        {
            collider.HitCollider(hitdamage);
            melon.Hit(collider.index, hitdamage);
        }
    }
}
