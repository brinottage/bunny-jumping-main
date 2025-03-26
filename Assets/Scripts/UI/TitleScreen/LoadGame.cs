using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI buttonName;
    [SerializeField] private Button thisButton; // Reference to the button

    void Start()
    {
        if (thisButton != null)
        {
            thisButton.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        string buttonText = buttonName.text.Trim();

        if (buttonText.Equals("Climbing", System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Climbing Mode Selected");
            SceneManager.LoadScene("SampleScene");
        }
        else if (buttonText.Equals("Racing", System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Racing Mode Selected");
            SceneManager.LoadScene("RacingGame");
        }
        else if (buttonText.Equals("Hopping", System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Hopping Mode Selected");
            SceneManager.LoadScene("HoppingGame");
        }
}
}
