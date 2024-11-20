using UnityEngine;
public class Player : MonoBehaviour
{
    private float moveH;
    public float moveV;
    public int velocidade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, moveV * velocidade * Time.deltaTime, 0);
    }
}
