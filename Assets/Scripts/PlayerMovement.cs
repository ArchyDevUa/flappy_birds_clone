using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using Button = UnityEngine.UI.Button;


public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody _rb;
    public float speed = 10.0f;
    private GameManager _gm;
    public TextMeshProUGUI text;
    private CapsuleCollider _capsuleCollider;
    public Button _btn;
    private AudioSource _mainTheme;
    [SerializeField] private AudioClip flySound;
    // Start is called before the first frame update
    void Start()
    {
        _gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
        _rb = GetComponent<Rigidbody>();
        _capsuleCollider = GetComponent<CapsuleCollider>();
        _mainTheme = GameObject.Find("Main Camera").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _gm._isGameContinue)
        {
            _rb.AddForce(Vector3.up * speed,ForceMode.Impulse );
            _mainTheme.PlayOneShot(flySound, 1.0f);
        }

        if (transform.position.y < -5)
        {
            gameOver();
        }

        if (transform.position.y > 5.5)
        {
            transform.position = new Vector3(transform.position.x,5.5f,transform.position.z);
            _rb.velocity = new Vector3(0,0,0);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameOver();
    }

    void gameOver()
    {
        _mainTheme.Stop();
        _gm._isGameContinue = false;
        text.gameObject.SetActive(true);
        _capsuleCollider.isTrigger = true;
        _btn.gameObject.SetActive(true);
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
