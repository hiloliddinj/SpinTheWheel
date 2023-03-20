using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject instractionPanel;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject loosePanel;

    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject gameScreen;

    void Start()
    {
        startScreen.SetActive(true);
        gameScreen.SetActive(false);
        instractionPanel.SetActive(false);
        winPanel.SetActive(false);
        loosePanel.SetActive(false);
    }

    public void ShowInstraction() {
        startScreen.SetActive(false);
        instractionPanel.SetActive(true);
    }

    public void GoToGameScreen()
    {
        instractionPanel.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void StartGame()
    {
        WheelSpeedControl.rotating = true;
    }

    public void WinPanelActivate()
    {
        gameScreen.SetActive(false);
        winPanel.SetActive(true);
    }

    public void LoosePanelActivate()
    {
        gameScreen.SetActive(false);
        loosePanel.SetActive(true);
    }

}
