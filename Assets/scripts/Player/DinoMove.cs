using UnityEngine;

public class DinoMove : MonoBehaviour
{
    [SerializeField]private int _jumpf = DinoStats.Instance.JumpForce;
    [SerializeField]private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("jump");
            _rb.AddForce(new Vector2(0, _jumpf), ForceMode2D.Impulse);
        }
    }
    private void FixedUpdate()
    {
       
    }
}
