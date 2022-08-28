using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    [SerializeField]
    AudioMain audioMain;
    [SerializeField]
    UIController UIController;

    public Levels[] levels;
    int levelNow = 1;
    [SerializeField]
    SpriteRenderer backGround;
    bool beginGame;
    private void Start()
    {
        audioMain.audioSource.Play();
    }
    public void NextLevel() {
        if (UIController._countIn == levels[levelNow - 1].scores + " / " + levels[levelNow - 1].scores) {
            levelNow++;
            LoadLevel(); 
        }
        
    }
    private void Update()
    {
        NextLevel();
        
    }
    void DestroyAll()
    {
        var go = GameObject.FindGameObjectsWithTag("bullet");
        var pl = GameObject.FindGameObjectsWithTag("platform");
        foreach (var item in go)
        {
            Destroy(item);
        }
        foreach (var item in pl)
        {
            Destroy(item);
        }
    }
    void LoadLevel()
    {
        
        DestroyAll();
        
        for (int i = 0; i < levels[levelNow - 1].colons.Count; i++)
        {
            Instantiate(levels[levelNow - 1].colons[i], levels[levelNow - 1].colonsPos[i]);
        }
        UIController.score = 0;
        UIController._level = "Level " + levelNow;
        UIController._countIn = "0 /" + levels[levelNow - 1].scores.ToString();
        UIController._countOut = levels[levelNow - 1].bullets.ToString();
    }
   
}
