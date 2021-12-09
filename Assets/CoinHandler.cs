using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinHandler : MonoBehaviour
{
    public static CoinHandler instance;
    public Text coinText;
    public int coinAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins : " + coinAmount;
    }
}
