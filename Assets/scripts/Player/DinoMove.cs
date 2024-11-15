using UnityEngine;

public class DinoMove : MonoBehaviour
{
    private int _jumpf = DinoStats.Instance.JumpForce;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Transform _checkObject;
    [SerializeField] private GameObject _gameOverMenu;
    [SerializeField] private GameOverScript _gameOver;
    [SerializeField] private CoinStats _coinStats;

    public LayerMask layerMask;
    
    [SerializeField] private bool _isGrounded;
    private void Awake()
    {
        _gameOverMenu.SetActive(false);
        _isGrounded = true;
        _rb = GetComponent<Rigidbody2D>();
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
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.7f,layerMask);
        Debug.DrawRay(transform.position, Vector3.down * 0.7f, Color.red);
        if (hit.collider != null)
        {
            _isGrounded = true;
            Debug.Log("ground");
        }
        else
        {
            Debug.Log("nothing");
        }
    }
    public void Death()
    {
        Time.timeScale = 0;
        _gameOverMenu.SetActive(true);
        _gameOver.ShowStatistics();
        DinoStats.Instance.SaveGame();
    }
    public void CoinPlus()
    {
        _coinStats.AddMoney();
    }
}
