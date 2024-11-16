using System.Collections;
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
            int obj_number=Random.Range(1, 15);
            if (obj_number >= 0 && obj_number <= 5)
            {
                Instantiate(structs[0], transform);
            }
            else if (obj_number > 5 && obj_number <= 7)
            {
                Instantiate(structs[1], transform);
            }
            else if (obj_number > 7 && obj_number <= 9)
            {
                Instantiate(structs[2], transform);
            }
            else if (obj_number >= 10 && obj_number < 12)
            {
                Instantiate(structs[3], transform);
            }
            else if(obj_number >= 12 && obj_number < 13)
            {
                Instantiate(structs[4], transform);
            }
            else Instantiate(structs[5], transform);
        }
    }
}
