using UnityEngine;

public class Attack : MonoBehaviour
{
        public int damage;

        private void OnTriggerEnter2D(Collider2D other)
        {
                if (other.CompareTag("Enemy"))
                {
                    other.gameObject.GetComponent<Life>().lifeAmount -= damage;
                    other.gameObject.GetComponent<Life>().UpdateHealthBar();
                    if (other.gameObject.GetComponent<Life>().lifeAmount <= 0) Destroy(other.gameObject);
                    Destroy(gameObject);
                }
        }
}
