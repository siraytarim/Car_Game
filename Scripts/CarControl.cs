using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CarControl : MonoBehaviour
{
    Rigidbody rb;

    public int puan;
    private void Start()
    {
        puan = 0;
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(rb.position.y <= -0.8)
        {
            Invoke("Die", .5f);
        }
        if(rb.position.z >= 126)
        {
            Invoke("Die", .5f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Invoke("Die", .5f);
        }
        if (collision.gameObject.CompareTag("Bar"))
        {
            Invoke("Die", .5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            puan++;
            Destroy(other.gameObject);
        }
    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
