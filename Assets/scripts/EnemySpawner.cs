using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float timeinterval;
    int enemyCounter;
    IEnumerator SpawnLogic()
    {
        while(true)
        {
        Debug.Log("kod fortsätter om 5 sekunder");
        yield return new WaitForSeconds(5f);
        Debug.Log("nu fortsätter koden");
            int x = Random.Range(-3, 3);
            int y = 6;
            enemyCounter = enemyCounter + 1;
            Instantiate(EnemyPrefab, new Vector2(x, y), Quaternion.identity);
           
        }
    }
    

    void Start()
    {
        StartCoroutine(SpawnLogic()); 
    }

    
    void Update()
    {
        
    }
}
