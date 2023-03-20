using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    [SerializeField] private GameObject pin;

    private Animator _animator;

    void Start()
    {
        _animator = pin.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(TagConst.handle))
        {
            _animator.SetTrigger(AnimeConst.swing);
        }
    }

}
