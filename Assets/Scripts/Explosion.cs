using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float damage = 25f;
    private void OnTriggerEnter2D (Collider2D collison)
    {
        Player player = collison.GetComponent<Player>();
        Enemy enemy = collison.GetComponent<Enemy>();
        if (collison.CompareTag("Player"))
        {
            player.TakeDame(damage);
        }
        if (collison.CompareTag("Enemy"))
        {
            enemy.TakeDame(damage);
        }

    }
    public void DestroyExplosion()
    {
        Destroy(gameObject);
    }
}
