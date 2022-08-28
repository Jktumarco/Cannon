using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField]
    UIController uIController;
    [SerializeField]
    GameObject prefabBullet;
    [SerializeField]
    Transform transformBullet;

    [SerializeField]
    float strikeSpeed;
    [SerializeField]
    AudioMain audioMain;
    
    private void Awake()
    {
        
    }
    public void CannonStrike()
    {
        
        int scroreCalculate = int.Parse(uIController._countOut) - 1;
        if (scroreCalculate < 0) { return; }
        else uIController._countOut = scroreCalculate.ToString();

        GameObject go = Instantiate(prefabBullet, transformBullet);
        var rigidbody = go.GetComponent<Rigidbody2D>();
        Vector2 temp = new Vector2(0, strikeSpeed);
        rigidbody.AddForce(temp);

        audioMain.audioStrike.Play();
        rigidbody.simulated = true;
    }
    //void CalculateScore() {
    //    int scroreCalculate = int.Parse(uIController._countOut) - 1;
    //    if(scroreCalculate < 0) { return; }
    //    else uIController._countOut = scroreCalculate.ToString();

    //}
}
