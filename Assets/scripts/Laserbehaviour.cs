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
    }
}
