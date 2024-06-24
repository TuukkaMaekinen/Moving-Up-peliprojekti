using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Firefly_Counter : MonoBehaviour
{
    TextMeshProUGUI text;
    public static int fireflyAmount;




    // Start is called before the first frame update
    void Start()
    {
        text= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = fireflyAmount.ToString();
    }
}
