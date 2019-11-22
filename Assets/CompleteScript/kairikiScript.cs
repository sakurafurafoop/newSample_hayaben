using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kairikiScript : MonoBehaviour {

    public GameObject benntou, pennote;
    // Use this for initialization
    void Start () {
        pennote.SetActive(true);
        benntou.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            pennote.SetActive(false);
            benntou.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            pennote.SetActive(true);
            benntou.SetActive(false);

        }
    }
}
