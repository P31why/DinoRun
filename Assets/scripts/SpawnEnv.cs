using System.Collections;
using UnityEngine;


public class SpawnEnv : MonoBehaviour
{
    [SerializeField] private GameObject[] enviroObjects;
    private void Start()
    {
        StartCoroutine(SpawnObj());
        
        
    }
    IEnumerator SpawnObj()
    {
        while (true)
        {
            int time = Random.Range(4,5);
            yield return new WaitForSeconds(time);
            int rand = Random.Range(1, 5);
            if (rand >= 1 && rand < 2)
            {
                Instantiate(enviroObjects[0], transform);
            }
            else
                Instantiate(enviroObjects[1], transform);
        }
    }
}
