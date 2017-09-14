using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceHandle : MonoBehaviour {

    private int gold;
    private float rate;
    private int buttonState;


    //Properties
    public int Gold
    {
        get
        {
            return gold;
        }
        set
        {
            gold = value;
        }
    }

    public float Rate
    {
        get
        {
            return rate;
        }
        set
        {
            rate = value;
        }
    }
    public int ButtonState
    {
        get
        {
            return buttonState;
        }
        set
        {
            buttonState = value;
        }
    }

    public Text goldText;
    public Text rateText;

    // Use this for initialization
    void Start () {
        Rate = 10;
        ButtonState = 5;
        Gold = 10;
        StartCoroutine("CollectGold");
        goldText.text = "Gold: " + Gold.ToString();
        rateText.text = "10 gold / " + Rate.ToString() + " seconds.";
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Rate is:" + rate);
        Debug.Log(buttonState );
        Debug.Log(gold);
    }

    public void UpgradeRate()
    {  
        ButtonState--;
        if (buttonState < 1)
            buttonState = 5;
        switch (buttonState)
        {
            case 1:
                Rate = 2;               
                break;
            case 2:
                Rate = 4;
                break;
            case 3:
                Rate = 6;
                break;
            case 4:
                Rate = 8;
                break;
            case 5:
                Rate = 10;
                break;
        }
        rateText.text = "10 gold / " + Rate.ToString() + " seconds.";
    }

    IEnumerator CollectGold()
    {   
        while(true)
        {
            yield return new WaitForSecondsRealtime(rate);
            Gold += 10;
            goldText.text = "Gold: " + Gold.ToString();
        } 
    }
}
