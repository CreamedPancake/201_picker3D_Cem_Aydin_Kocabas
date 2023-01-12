using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private GameObject getgem1;
    public int NumberOfDiamonds { get; private set; }
   

    void Start()
    {
        getgem1 = GameObject.Find("Canvas1");
    }
    
    

    public void DiamondCollected()
    {
        NumberOfDiamonds += 50;
        getgem1.GetComponentInChildren<TextMeshProUGUI>().text = NumberOfDiamonds.ToString();
    }
}
