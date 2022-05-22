using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGift : MonoBehaviour
{
    public GameObject player;
    
    private void OnTriggerEnter (Collider other) {
        int remainGift = FindObjectOfType<ControllerForGame>().GiftInLvl;
        if(other.gameObject == player && remainGift == 0){
            FindObjectOfType<AudioManager>().Play("Win");
            FindObjectOfType<ControllerForGame>().showWinDialogue();
            Destroy(gameObject);
        }
    }

}
