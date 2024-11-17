using UnityEngine;

public class DinoMove : MonoBehaviour
{
    private int _jumpf = DinoStats.Instance.JumpForce;
    private int _currentSkin;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Transform _checkObject;
    [SerializeField] private GameObject _gameOverMenu;
    [SerializeField] private GameOverScript _gameOver;
    [SerializeField] private CoinStats _coinStats;

    [SerializeField] private Animator _animator;

    public LayerMask layerMask;
    
    [SerializeField] private bool _isGrounded;
    private void Awake()
    {
        _gameOverMenu.SetActive(false);
        _isGrounded = true;
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        if (DinoStats.Instance.SetSkin == 0)
        {
            _animator.Play("Run");
            _currentSkin = 0;
        }
        else if (DinoStats.Instance.SetSkin==1)
        {
            _animator.Play("RedRun");
            _currentSkin = 1;
        }
        else if(DinoStats.Instance.SetSkin == 2)
        {
            _animator.Play("BlueRun");
            _currentSkin = 2;
        }        
        else if(DinoStats.Instance.SetSkin == 3)
        {
            _animator.Play("YellowRun");
            _currentSkin = 3;
        }
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
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.8f,layerMask);
        Debug.DrawRay(transform.position, Vector3.down * 0.7f, Color.red);
        if (hit.collider.tag == "ground")
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
        if (_currentSkin == 0)
        {
            _animator.Play("Death");
        }
        else if (_currentSkin == 1)
        {
            _animator.Play("RedDeath");
        }
        else if (_currentSkin == 2)
        {
            _animator.Play("BlueDeath");
        }
        else if (_currentSkin == 3)
        {
            _animator.Play("YellowDeath");
        }
        else
        {
            _animator.Play("Death");
        }

        _gameOverMenu.SetActive(true);
        Time.timeScale = 0;
        _gameOver.ShowStatistics();
        DinoStats.Instance.SaveGame();
    }
    public void CoinPlus()
    {
        _coinStats.AddMoney();
    }
}
