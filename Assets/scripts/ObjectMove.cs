using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 dir;
    private void Awake()
    {
        StartCoroutine(DeleteThisObj());
    }
    private void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    IEnumerator DeleteThisObj()
    {
        yield return new WaitForSeconds(20);
        Destroy(gameObject);
    }
}
