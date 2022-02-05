using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This responds to the box collider acting as a trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.LoadEndScene();
    }
}
