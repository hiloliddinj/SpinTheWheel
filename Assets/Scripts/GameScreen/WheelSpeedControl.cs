using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelSpeedControl : MonoBehaviour
{

    [SerializeField] private GameObject gameManager;
    [SerializeField] private GameObject sliderOnPlayButton;

    private Slider _slider;
    private GameManager _gameManager;

    private float _rotationSpeed;
    private const float _maxRotationSpeed = 500f;
    private const float _rotationSpeedDecrease = 50f;

    public static bool rotating = false;
    private bool isPressedButtonStarted = false;
    private bool isPressedButtonFinished = false;

    private bool _rotationSpeedIsSet = false;

    private void Start()
    {
        _slider = sliderOnPlayButton.GetComponent<Slider>();
        _gameManager = gameManager.GetComponent<GameManager>();

        _rotationSpeed = _maxRotationSpeed;
        _slider.value = 0;
    }

    private void FixedUpdate()
    {
        RotateWheel(Get_gameManager());
        UpdateSlider();
    }

    public void StartSlider()
    {
        isPressedButtonStarted = true;
    }

    public void StopSlider()
    {
        isPressedButtonFinished = true;
    }

    private void UpdateSlider()
    {
        if (isPressedButtonStarted && !isPressedButtonFinished)
        {
            _slider.value += 1f * Time.deltaTime;

            if (_slider.value == 1)
            {
                _slider.value = 0;
            }
        }
    }

    private GameManager Get_gameManager()
    {
        return _gameManager;
    }

    private void RotateWheel(GameManager _gameManager)
    {
        if (isPressedButtonFinished)
        {
            if (!_rotationSpeedIsSet)
            {
                _rotationSpeedIsSet = true;
                _rotationSpeed = _slider.value * _maxRotationSpeed;
            }

            if (rotating && _rotationSpeed > 0)
            {
                _rotationSpeed -= _rotationSpeedDecrease * Time.deltaTime;

                if (_rotationSpeed < 25)
                {
                    PinController.animationSpeed = 1.0f;
                } else
                {
                    PinController.animationSpeed = _rotationSpeed / 20;
                }

                gameObject.transform.Rotate(0, 0, _rotationSpeed * Time.deltaTime);
            }

            if (_rotationSpeed <= 0)
            {
                if (_slider.value < 0.5f)
                {
                    _gameManager.Invoke("LoosePanelActivate", 2);
                }
                else
                {
                    _gameManager.WinPanelActivate();
                    _gameManager.Invoke("WinPanelActivate", 2);
                }
            }
        }
    }
}
