using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    [SerializeField] GameObject bCredit;
    [SerializeField] GameObject bOption;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToGame()
    {
        SceneManager.LoadScene("Feur");
        Time.timeScale = 1;
    }

    public void Credit()
    {
        bCredit.gameObject.SetActive(true);       
    }

    public void Option()
    {
        bOption.gameObject.SetActive(true);
    }

    public void bHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}