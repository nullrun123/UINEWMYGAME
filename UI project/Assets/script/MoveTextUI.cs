using UnityEngine;
using UnityEngine.UI;

public class TextEffect : MonoBehaviour
{
    public Text textField;
    public Button button; // เพิ่มตัวแปร Button เข้ามา
    public string message;
    public float letterDelay = 0.1f;

    private float timer;
    private int currentLetterIndex;

    void Start()
    {
        timer = letterDelay;
        currentLetterIndex = 0;
        button.gameObject.SetActive(false); // เริ่มต้นซ่อน Button UI
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            // Add the next letter to the text field
            textField.text += message[currentLetterIndex];
            currentLetterIndex++;

            // Reset timer
            timer = letterDelay;

            // Check if we've reached the end of the message
            if (currentLetterIndex >= message.Length)
            {
                enabled = false; // Disable this script when the message is fully displayed
                button.gameObject.SetActive(true); // แสดง Button UI เมื่อ text สิ้นสุด
            }
        }
    }

    // Function to show all text when button is clicked
    public void ShowAllText()
    {
        // Set text field to display the entire message
        textField.text = message;
        // Disable this script since the entire message is now displayed
        enabled = false;
        button.gameObject.SetActive(true); // แสดง Button UI เมื่อ text สิ้นสุด
    }
}
