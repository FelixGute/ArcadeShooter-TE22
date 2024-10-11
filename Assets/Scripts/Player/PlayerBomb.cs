using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBomb : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float bombFuse = 3f;
    [SerializeField] float radius = 2f;
    [SerializeField] LayerMask enemyLayerMask;

    float triggerTime = 0f;

    void Start()
    {
        triggerTime = Time.time + bombFuse;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > triggerTime)
        {
            // Trigger explosion
            Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, radius, enemyLayerMask);
            foreach (Collider2D hit in hits)
            {
                Destroy(hit.gameObject);
            }
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
