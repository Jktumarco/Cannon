using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class BasketCollision : MonoBehaviour
{
    [SerializeField]
    UIController UIController;
    
    
    BoxCollider2D coll;

    public GameObject text;
    void Start()
    {
        
        BoxCollider2D coll = GetComponent<BoxCollider2D>();
       
    }
   
    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "bullet") {
            if (coll.gameObject.GetComponent<Bullet>().basket == followBasket.offBasket) {
               UIController.score += 1;  UIController._countIn = UIController.score.ToString() + " / 20"; 
                coll.gameObject.GetComponent<Bullet>().basket = followBasket.inBasket; 
            }
        }
    }
   

}
