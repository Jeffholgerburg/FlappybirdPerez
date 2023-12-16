using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject  GameOverText;
    public TextMeshProUGUI scoreText;
    public bool GameOver = false;
    public float scrollSpeed = -1.5f;
    private int score = 0;

    AudioSource audioSource;
    public AudioClip scoreSound;

    // Start is called before the first frame update
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver == true && Input.GetMouseButton(0))
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        }
    }
    public void BirdScored()
    {
        if(GameOver)
        {
            return;
        }
        score++;
        scoreText.text = "score " + score.ToString();
        PlaySound(scoreSound);
    }
    public void BirdDead()
    {
        GameOverText.SetActive(true);
        GameOver = true;
    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
