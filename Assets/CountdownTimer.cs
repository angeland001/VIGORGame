using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3f;
    public Text countdownText;
    public Text gameExplanationText;
    bool countdownStarted = false;

    void Start()
    {
        // Show game explanation text for 3 seconds before starting countdown
        StartCoroutine(ShowExplanationAndStartCountdown());
    }

    IEnumerator ShowExplanationAndStartCountdown()
    {
        // Display game explanation text
        gameExplanationText.enabled = true;
        yield return new WaitForSeconds(3f); // Adjust the duration of explanation text display

        // Start countdown
        countdownStarted = true;
        currentTime = startingTime;
        gameExplanationText.enabled = false; // Hide game explanation text
    }

    void Update()
    {
        if (countdownStarted)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                countdownText.text = "Go!";

                // Disable the countdown text
                countdownText.enabled = false;

                // Disable the CountdownTimer script to stop further updates
                enabled = false;
            }
            else
            {
                countdownText.text = currentTime.ToString("0");
            }
        }
    }
}
