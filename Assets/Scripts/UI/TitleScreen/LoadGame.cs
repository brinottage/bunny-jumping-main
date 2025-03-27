using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI buttonName; // The button's name, in text
    [SerializeField] private Button thisButton; // Reference to the button itself

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

        // Each if statement loads the Climbing Game, Racing Game, and Hopping Game respectively
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
