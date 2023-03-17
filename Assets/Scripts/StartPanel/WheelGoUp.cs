using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WheelGoUp : MonoBehaviour
{
    [SerializeField] private GameObject _wheel; 

    public bool startToGoUp = false;
    
    void Start()
    {
        Invoke(nameof(SetStartToGoUp), 1);
    }

    void Update()
    {
        StartToGoUp();
    }

    private void SetStartToGoUp()
    {
        startToGoUp = true;
        _wheel.GetComponent<AutoWheelController>().startRotation = true;
    }

    private void StartToGoUp()
    {
        if (startToGoUp)
        {
            Vector3 target = new Vector3(transform.position.x, 1.9f, transform.position.z);

            transform.position = Vector3.MoveTowards(
                transform.position,
                target,
                5f * Time.deltaTime
                );
        }

        
    }


}
