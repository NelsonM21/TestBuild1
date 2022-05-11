using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDectector : MonoBehaviour
{
    public float hitCounter = 0;
    public float radiusCounter = 0;
    public TextMeshProUGUI hitCounterText;
    public TextMeshProUGUI radiusCounterText;
    public GameObject playerCharacter;

    // Start is called before the first frame update//
    void Start()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hitCounter += 1;
            print("I've been had " + hitCounter + "times");
            hitCounterText.text = "Hit Counter: " + hitCounter.ToString();

            if (hitCounter >= 5)
            {
                playerCharacter.SetActive(false);
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        hitCounter += 1;
        radiusCounter += 1;
        radiusCounterText.enabled = true;
        radiusCounterText.text = "I smell the smelly smell of someone tyring to take me money " + radiusCounter.ToString() + " times";
        print("I smell the smelly smell of someone trying to take me money" + radiusCounter + "times.");
        hitCounterText.enabled = true;
        hitCounterText.text = "Hit Counter: " + hitCounter;
        if (hitCounter == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        radiusCounterText.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}