using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinPanelWheelControl : MonoBehaviour
{
    //TODO: Become bigger and smaller with speed and rotate

    [SerializeField] private GameObject wheel;
    [SerializeField] private TextMeshProUGUI prizeValue;

    private Vector3 scaleChange;
    private float _amount = -0.1f;

    private void Awake()
    {
        scaleChange = new Vector3(_amount, _amount, _amount) * Time.deltaTime;
        prizeValue.SetText("$123");
    }

    private void Update()
    {
        Scale();
        Rotate();
    }

    private void Scale()
    {
        transform.localScale += scaleChange;
        if (transform.localScale.y < 0.5f || transform.localScale.y > 1.5f)
        {
            scaleChange = -scaleChange;
        }
    }

    private void Rotate()
    {
        wheel.transform.Rotate(0, 0, 30 * Time.deltaTime);
    }
}
