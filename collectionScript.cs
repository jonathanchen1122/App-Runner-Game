using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectionScript : MonoBehaviour
{
    public int coins;
    public int gems;
    public bool powered;

    public Text coinText;
    public Text gemText;

    void Start()
    {
        powered = false;
    }

    void Update()
    {
        coinText.text = coins.ToString();
        gemText.text = gems.ToString();
    }
}
