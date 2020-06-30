using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _poofParticlePrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bird bird = collision.collider.GetComponent<Bird>();
        if ( bird == true)
        {
            Instantiate(_poofParticlePrefab,transform.position,Quaternion.identity);
            Destroy(gameObject);
            return;
        }

        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy == true )
        {
            return;
        }

        if ( collision.contacts[0].normal.y < -0.5 )
        {
            Instantiate(_poofParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            return;
        }
    }
}
