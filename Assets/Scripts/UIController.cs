using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    GameObject countIn;
    [SerializeField]
    GameObject countOut;
    [SerializeField]
    GameObject level;
    [SerializeField]
    Button soundOff;
    [SerializeField]
    Button menu;
    [SerializeField]    
    AudioMain audioMain;
    public int score = 0;

    public string _countIn {
        get { return countIn.GetComponent<TextMeshProUGUI>().text; }
        set { countIn.GetComponent<TextMeshProUGUI>().text = value; } 
    }
    public string _countOut
    {
        get { return countOut.GetComponent<TextMeshProUGUI>().text; }
        set { countOut.GetComponent<TextMeshProUGUI>().text = value; }
    }
    public string _level
    {
        get { return level.GetComponent<TextMeshProUGUI>().text; ; }
        set { level.GetComponent<TextMeshProUGUI>().text = value; }
    }
   

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
