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
        Debug.Log($"Click: '{buttonText}'");

        if (buttonText.Equals("Climbing", System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Moving Scenes");
            SceneManager.LoadScene("SampleScene");
        }
        else if (buttonText.Equals("Racing", System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Racing Mode Selected");
        }
        else if (buttonText.Equals("Hopping", System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Hopping Mode Selected");
        }
}
}
