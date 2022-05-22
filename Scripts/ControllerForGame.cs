using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControllerForGame : MonoBehaviour
{

    public GameObject ForNextLevelDialogue;

    public int GiftInLvl;

    public TMP_Text WinText;

    public TMP_Text GiftInScreen;

    public void getGift() {
        if(GiftInLvl > 1)
        {
            GiftInLvl -= 1;
            SomeUpdate();
        } else {
            GiftInLvl -= 1;
            SomeWin();
        }
        
    }

    void Start() {
        SomeUpdate();
    }

    void SomeUpdate() {
        GiftInScreen.text = "GIFT: " + GiftInLvl;    
    }

    void SomeWin(){
        GiftInScreen.text = "Find last gift";
    }

    public void showWinDialogue(){
        ForNextLevelDialogue.SetActive(true);
    }


}
