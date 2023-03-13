using UnityEngine;

public class WheelControl : MonoBehaviour
{

    [SerializeField] private GameObject gameManager;

    private float _rotationSpeed;
    private const float _maxRotationSpeed = 200f;
    private const float _rotationSpeedDecrease = 50f;

    public static bool rotating = false;

    private void Start()
    {
        _rotationSpeed = _maxRotationSpeed;
    }

    void Update()
    {
        if (rotating && _rotationSpeed > 0)
        {
            _rotationSpeed -= _rotationSpeedDecrease * Time.deltaTime;

            transform.Rotate(0, 0, _rotationSpeed * Time.deltaTime);
        }

        if (_rotationSpeed <= 0)
        {
            gameManager.GetComponent<GameManager>().WinPanelActivate();
        }
        
    }
}
