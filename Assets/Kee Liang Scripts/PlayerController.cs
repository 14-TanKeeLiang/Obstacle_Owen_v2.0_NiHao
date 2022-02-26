using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int coinCollected;
    private float timer;

    private AudioSource audioSource;

    public AudioClip[] audioClips;
    public Text coinCollectedTxt;
    public Text timerTxt;

    private int buildIn;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        buildIn = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        DisplayTime(timer);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Win"))
        {
            SceneManager.LoadScene("GameWin");
        }
        if (other.gameObject.CompareTag("Water") || other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("GameLose");
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerTxt.text = "Time Left: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
