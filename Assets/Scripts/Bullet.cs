using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum followBasket { inBasket, offBasket };
public class Bullet : MonoBehaviour
{
    public followBasket basket;
    void Start()
    {
        basket = followBasket.offBasket;
    }

}
