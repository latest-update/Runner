using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void startGame() {
        Time.timeScale = 1f;
    }
    
    void pauseGame(){
        Time.timeScale = 0f;
    }

}
