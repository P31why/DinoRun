using System.Collections;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 dir;
    private void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.collider.GetComponent<DinoMove>().CoinPlus();
            StartCoroutine(CoinDelete());
        }
    }
    IEnumerator CoinDelete()
    {
        yield return new WaitForSeconds(1);
    }
}
