﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionController : MonoBehaviour
{
    // Start is called before the first frame update
    

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Player"){
            PlayerController.collectedAmount++;
            if(PlayerController.collectedAmount%5 == 0){
                PlayerController.spawnOnce = true;
            }
            ControlScript.timer += 2f;
            Destroy(gameObject);
        }
    }
}
