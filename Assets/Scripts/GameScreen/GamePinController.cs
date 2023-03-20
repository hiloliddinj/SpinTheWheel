using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePinController : MonoBehaviour
{
    [SerializeField] private GameObject pin;

    private Animator _animator;
    private AudioSource _audioSource;

    public static float animationSpeed = 1.0f;

    void Start()
    {
        _animator = pin.GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(TagConst.handle))
        {
            _animator.speed = animationSpeed;
            _animator.SetTrigger(AnimeConst.swing);
            _audioSource.Play();
        }
    }
}
