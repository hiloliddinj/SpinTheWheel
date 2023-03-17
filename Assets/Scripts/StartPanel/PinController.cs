using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    [SerializeField] private GameObject pin;

    private Animator _animator;
    private AudioSource _audioSource;

    void Start()
    {
        _animator = pin.GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HELLO");
        if (other.gameObject.CompareTag("handle"))
        {
            _animator.SetTrigger("swing");
            _audioSource.Play();
        }
    }

}
