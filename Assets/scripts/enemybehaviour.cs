using UnityEngine;

public class enemybehaviour : MonoBehaviour
{

    public float speed;
    public int hp = 10;
    
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
        
        
        hp = hp - 1;
        if (hp <= 0)
        { 
          Destroy(gameObject);

        }
      
        

    }
}