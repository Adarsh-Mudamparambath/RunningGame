using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;
    public float playerSpeed = 2;
    public float horizontalSpeed = 3;

    // Update is called once per frame
    void Update()
    {
        if(!alive) return;
        
        transform.Translate(Vector3.forward * (Time.deltaTime * playerSpeed), Space.World);

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(Vector3.left * (Time.deltaTime * horizontalSpeed) );

        }
        if(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(Vector3.left * (Time.deltaTime * horizontalSpeed * -1));

        }

        if (transform.position.y < -5)
        {
            Die();
        }
    }

    public void Die()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
