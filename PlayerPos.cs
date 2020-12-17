using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    public GameObject gameOver;
    private GameMaster gm;
    public GameObject CameraFollow;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        /*CameraFollow = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>();*/
        transform.position = gm.lastCheckPointPos;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("FALL"))
        {
            Time.timeScale = 0;
            gameOver.gameObject.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        /*if (other.CompareTag("Ngetest"))
        {
            CameraFollow.GetComponent<CameraFollow>().isStarted = false;
        }*/
    }

    //void Update()
    //{
    //    if (Input.GetKeyDown("o"))
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    }
    //}
}
