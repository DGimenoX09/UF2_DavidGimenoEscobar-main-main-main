using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountManager : MonoBehaviour
{
    public Text countText;
    public int countGoomba; 
    // Start is called before the first frame update
    void Start()
    {
        countGoomba = 0;
    }
    public void LoadGoombaCount(){
        countGoomba++;
        Debug.Log(countGoomba);
        countText.text = "Goombas: "+countGoomba.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
