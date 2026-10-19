using UnityEngine;

public class enemybehaviour : MonoBehaviour
{

    public float speed;
    public int hp = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
     transform.Translate(Vector2.down * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Laserbehaviour>();
        
        hp = hp - 1;
        if (hp <= 0)
        { 
          Destroy(gameObject);
        }
      
        Destroy(other.gameObject);

    }
}