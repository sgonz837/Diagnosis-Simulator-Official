using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits_Script : MonoBehaviour
{
    //public GameObject Panel;
    Rigidbody rb;
    public float speed = 5f;
    public float time = 40;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        time = 40;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * speed;
        if (time <= 0.0f)
        {
            SceneManager.LoadScene(0);
        }
        time -= Time.deltaTime;
        //Panel.transform.position = Vector3.up * speed; ;
        //Panel.velocity = transform.up * speed;
    }
}
