using Unity.VisualScripting;
using UnityEngine;

public class Laserbehaviour : MonoBehaviour
{
    public float LaserSpeed = 5f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        this.transform.Translate(Vector2.up * LaserSpeed * Time.deltaTime);

        if (transform.position.y > 6) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
