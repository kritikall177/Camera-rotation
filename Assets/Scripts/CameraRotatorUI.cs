using UnityEngine;
using UnityEngine.UI;

public class CameraRotatorUI : MonoBehaviour
{
    [SerializeField] private CameraRotator _rotator;
    [SerializeField] private Button _rotationModeButton;
    [SerializeField] private Text _buttonText;
    
    private void Start()
    {
        _rotationModeButton.onClick.AddListener(RotationModeButtonOnClick);
    }

    private void RotationModeButtonOnClick()
    {
        SetRotationModeButtonText();
        _rotator.ChangeMode();
    }
    
    private void SetRotationModeButtonText()
    {
        switch (_rotator.IsAuto)
        {
            case true:
                _buttonText.text = "Ручной";
                break;
            case false:
                _buttonText.text = "Авто";
                break;
        }
    }
}
