using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProps : MonoBehaviour
{
    [SerializeField] private GameObject[] structs;
    private void Awake()
    {
        StartCoroutine(SpawnObjects());
    }
    IEnumerator SpawnObjects()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            int obj_number=Random.Range(1, 10);
            if(obj_number>=0 && obj_number<=4)
            {
                Instantiate(structs[0], transform);
            }
            
            /*else if (obj_number >= 4 && obj_number <= 5)
            {
                Instantiate(structs[1], transform);
            }*/
            
        }
    }
}
