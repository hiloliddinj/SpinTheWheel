using UnityEngine;
using UnityEngine.UI;

public class WheelControl : MonoBehaviour
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

    void Update()
    {
        RotateWheel();
        UpdateSldier();
    }

    public void StartSlider()
    {
        Debug.Log("Started Slider");
        isPressedButtonStarted = true;
    }

    public void StopSlider()
    {
        Debug.Log("Stoped Slider");
        isPressedButtonFinished = true;
    }

    private void UpdateSldier()
    {
        if (isPressedButtonStarted && !isPressedButtonFinished) {
            _slider.value += 1f * Time.deltaTime;

            if (_slider.value == 1)
            {
                _slider.value = 0;
            }
        }
        
    }

    private void RotateWheel()
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

                transform.Rotate(0, 0, _rotationSpeed * Time.deltaTime);
            }

            if (_rotationSpeed <= 0)
            {
                if (_slider.value < 0.5f)
                {
                    _gameManager.LoosePanelActivate();
                }
                else
                {
                    _gameManager.WinPanelActivate();
                }

                
            } 
        }

        
    }
}
