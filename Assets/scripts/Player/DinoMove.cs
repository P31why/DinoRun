using UnityEngine;

public class DinoMove : MonoBehaviour
{
    private int _jumpf = DinoStats.Instance.JumpForce;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Transform _checkObject;
    [SerializeField] private GameObject _gameOverMenu;
    public LayerMask layerMask;
    
    [SerializeField] private bool _isGrounded;
    private void Awake()
    {
        _isGrounded = true;
        _rb = GetComponent<Rigidbody2D>();
        _gameOverMenu.SetActive(false);
    }
    private void Update()
    {
        Jumping();
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rb.AddForce(new Vector2(0, _jumpf), ForceMode2D.Impulse);
            _isGrounded = false;
            Debug.Log("jump");
        }
       
    }
    private void Jumping()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1,layerMask);
        Debug.DrawRay(transform.position, Vector3.down * 1, Color.red);
        if (hit.collider.CompareTag("ground"))
        {
            _isGrounded = true;
            Debug.Log("ground");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "death")
        {
            _gameOverMenu.SetActive(true);
        }
    }
}
