using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AutoWheelController : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> prize1;
    [SerializeField] private List<TextMeshProUGUI> prize2;
    [SerializeField] private List<TextMeshProUGUI> prize3;
    [SerializeField] private List<TextMeshProUGUI> prize4;
    [SerializeField] private List<TextMeshProUGUI> prize5;
    [SerializeField] private List<TextMeshProUGUI> prize6;

    public bool startRotation = false;


    private void Start()
    {
        SetPrizevalues();
    }


    private void FixedUpdate()
    {
        if (startRotation)
        {
            gameObject.transform.Rotate(0, 0, 10 * Time.deltaTime);
        }
        
    }

    private void SetPrizevalues()
    {
        foreach(TextMeshProUGUI textM in prize1)
        {
            textM.SetText("No prize");
        }
        foreach (TextMeshProUGUI textM in prize2)
        {
            textM.SetText("$5");
        }
        foreach (TextMeshProUGUI textM in prize3)
        {
            textM.SetText("$10");
        }
        foreach (TextMeshProUGUI textM in prize4)
        {
            textM.SetText("$25");
        }
        foreach (TextMeshProUGUI textM in prize5)
        {
            textM.SetText("$50");
        }
        foreach (TextMeshProUGUI textM in prize6)
        {
            textM.SetText("$100");
        }
    }
}
