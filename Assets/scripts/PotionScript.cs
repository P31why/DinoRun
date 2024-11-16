using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour
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
        yield return new WaitForSeconds(15);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject ob=collision.collider.gameObject;
            if (ob.GetComponent<CoinStats>().DoubleMoney == false)
            {
                ob.GetComponent<CoinStats>().DoubleMoneyON();
            }
            Destroy(gameObject);
        }
    }
}
