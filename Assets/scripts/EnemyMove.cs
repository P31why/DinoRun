using System.Collections;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 dir;
    private void Awake()
    {
        StartCoroutine(DeleteThisObj());
    }
    private void Update()
    {
        transform.Translate(dir * speed*Time.deltaTime);
    }
    IEnumerator DeleteThisObj()
    {
        yield return new WaitForSeconds(15);
        Destroy(gameObject);
    }
}
