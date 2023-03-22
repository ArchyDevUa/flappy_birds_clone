using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScore : MonoBehaviour
{
    private GameManager _gm;

    private void Start()
    {
        _gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _gm.ChangeScore();
    }
}
