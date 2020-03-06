using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class displayText : MonoBehaviour
{
    public Text woodAmount, stoneAmount, sandAmount, lvl2Good, lvl3Good, lvl3Good2, lvl4Good,lvl4Good2, lvl5Good, lvl5Good2;
    public Item itemRef;
    public TextMeshProUGUI text;
    public Text btnText1, btnText2;
    public string doYouWannaBuildIt = "Do you want to build it?";
    public string yes = "Yes";
    public string no = "No";
    public string upgradeYourBase = "Upgrade your base";
    // Start is called before the first frame update
    void Start()
    {
        btnText1.text = "Yes";
        btnText2.text = "No";
        text.text = "Do you want to build it?";
    }

    // Update is called once per frame
    void Update()
    {
        woodAmount.text = "Wood: " + itemRef.woodAmount.ToString();
        stoneAmount.text = "Stone: " + itemRef.stoneAmount.ToString();
        sandAmount.text = "Sand: " + itemRef.sandAmount.ToString();
        lvl2Good.text = "Good1: " + itemRef.lvl2Good2.ToString();
        lvl3Good.text = "Good1: " + itemRef.lvl3Good1.ToString();
        lvl3Good2.text = "Good1: " + itemRef.lvl3Good2.ToString();
        lvl4Good.text = "Good1: " + itemRef.lvl4Good1.ToString();
        lvl4Good2.text = "Good1: " + itemRef.lvl4Good2.ToString();
        lvl5Good.text = "Good1: " + itemRef.lvl5Good1.ToString();
        lvl5Good2.text = "Good1: " + itemRef.lvl5Good2.ToString();

    }
}
