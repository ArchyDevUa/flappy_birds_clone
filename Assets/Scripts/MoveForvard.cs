using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForvard : MonoBehaviour
{
    public float speed = 1.0f;
    private GameManager _gm;
    // Start is called before the first frame update
    void Start()
    {
        _gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (_gm._isGameContinue)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        
    }
}
