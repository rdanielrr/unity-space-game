using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public Transform Bullet;
    public Transform CannonPosition;
    public int Score;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = ("Score: " + Score);
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(h, v, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();

        }
    }

    void OnTriggerEnter(Collider Meteor)
    {
        if (Meteor.gameObject.CompareTag("Player"))
        {
            Meteor.gameObject.SetActive(false);
        }
    }


    void Shoot() {
        Instantiate(Bullet, CannonPosition.position, Quaternion.identity);
    }
}
