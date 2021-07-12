using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    private float projectileForce = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity);
            // ReSharper disable once PossibleNullReferenceException
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mousePos - (Vector2)transform.position).normalized;
            bullet.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
        }
    }
}
