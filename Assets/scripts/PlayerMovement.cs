using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    public int playerHp = 10;
    public GameObject LaserShot;
    public Slider PlayerHealthBar;
    private void Start()
    {
        PlayerHealthBar.maxValue = playerHp;
        this.transform.position = new Vector2(0, -3.65f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.name == "enemy")
        {
            playerHp = playerHp - 1;
            
            if (playerHp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Update()
    {
        float playerSpeed = 1f;
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right* playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(LaserShot, this.transform.position, Quaternion.identity);
        }
       
    }

}


