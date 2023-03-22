using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObsticle : MonoBehaviour
{
    public GameObject obsticle;
    private GameManager _gm;
    // Start is called before the first frame update
    void Start()
    {
        _gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
        InvokeRepeating("spawmObsticle",1,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawmObsticle()
    {
        if (_gm._isGameContinue)
        {
            Instantiate(obsticle, new Vector3(0, Random.Range(-3,3), 7), obsticle.transform.rotation);
        }
    }
}
