using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnCollision : MonoBehaviour
{
    public int scenename;
    public int nextscene;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("candy"))
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

            SceneManager.LoadScene(nextscene);
        if (collision.gameObject.CompareTag("respawn"))
            SceneManager.LoadScene(scenename);
    }
}

