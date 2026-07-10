using UnityEngine;
public class pootamotion : MonoBehaviour
{
   [SerializeField] private float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        Debug.Log(moveInput);
    }
    void FixedUpdate()
    {
        rb.linearVelocity = moveInput.normalized * speed;
    }
}
