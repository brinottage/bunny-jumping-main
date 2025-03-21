using TMPro;
using UnityEngine;

public class HoppingMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float maxCharge = 2f;  
    public float maxJumpForce = 10f; 
    private float charge = 0f;
    private bool isCharging = false;

    [SerializeField] TextMeshProUGUI chargeDisplayText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Charging
            charge += Time.deltaTime;
            charge = Mathf.Min(charge, maxCharge);
            isCharging = true;
        }

        if (Input.GetKeyUp(KeyCode.Space) && isCharging)
        {
            // Jump force is calculated and applied
            float jumpForce = (charge / maxCharge) * maxJumpForce;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

            // Charge resets
            charge = 0f;
            isCharging = false;
        }

        UpdateChargeDisplayText();
    }

    void UpdateChargeDisplayText()
    {
        if (chargeDisplayText != null)
        {
            chargeDisplayText.text = "Charge: " + Mathf.Round(charge / maxCharge * 100);
        }
    }
}
