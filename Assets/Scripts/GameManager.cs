using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject instractionPanel;
    [SerializeField] private GameObject gamePanel;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject loosePanel;

    void Start()
    {
        //startPanel.SetActive(true);
        //instractionPanel.SetActive(false);
        //gamePanel.SetActive(false);
        //winPanel.SetActive(false);
        //loosePanel.SetActive(false);
    }

    public void ShowInstraction() {
        startPanel.SetActive(false);
        instractionPanel.SetActive(true);
    }

    public void GoToGameScreen()
    {
        instractionPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public void StartGame()
    {
        WheelControl.rotating = true;
    }

    public void WinPanelActivate()
    {
        winPanel.SetActive(true);
    }

    public void LoosePanelActivate()
    {
        loosePanel.SetActive(true);
    }

}
