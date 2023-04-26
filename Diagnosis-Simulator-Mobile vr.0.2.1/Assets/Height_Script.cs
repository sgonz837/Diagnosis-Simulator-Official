using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Height_Script : MonoBehaviour
{
    public GameObject player;
    Scrollbar scrollBar;
    
    // Start is called before the first frame update
    void Start()
    {
        scrollBar = GetComponent<Scrollbar>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = player.transform.position;
        pos.y = scrollBar.value * 20;
        player.transform.position = pos;
    }
}
