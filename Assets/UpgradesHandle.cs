using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesHandle : MonoBehaviour {
    public List<string > abilities = new List<string>();
    public Dropdown abilitiesDD;
    public ResourceHandle resourceInv;
    public Text abilityText;
	// Use this for initialization
	void Start () {
        abilitiesDD.AddOptions(abilities);
	}
	
    public void BuyAbility()
    {
        if(abilitiesDD .value == 0 && resourceInv .Gold > 20)
        {
            abilityText.text = "Ability used: " + abilitiesDD.captionText.text;
            resourceInv.Gold -= 20;
        }
        if (abilitiesDD.value == 1 && resourceInv.Gold > 35)
        {
            abilityText.text = "Ability used: " + abilitiesDD.captionText.text;
            resourceInv.Gold -= 35;
        }
        if (abilitiesDD.value == 2 && resourceInv.Gold > 50)
        {
            abilityText.text = "Ability used: " + abilitiesDD.captionText.text;
            resourceInv.Gold -= 50;
        }
        if (abilitiesDD.value == 3 && resourceInv.Gold > 70)
        {
            abilityText.text = "Ability used: " + abilitiesDD.captionText.text;
            resourceInv.Gold -= 70;
        }

    }

	// Update is called once per frame
	void Update () {
		
	}
}
