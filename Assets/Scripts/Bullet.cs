using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    public float atk = 50f;
    private Rigidbody rb;
    public string nextScene;

    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // 如果碰撞到的是子彈
        if (other.tag == "Enemy")
        {
            // 刪除自己
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
          if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

            GameObject[] objs = GameObject.FindGameObjectsWithTag("Enemy");

            if (objs.Length == 0)
            {
    
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
