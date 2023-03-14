using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // The player's movement speed
    public float padding = 1f; // The padding between the player and the camera edges

    private Rigidbody2D rb;
    private Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    void FixedUpdate()
    {
        // Get the mouse position
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        // Move the player towards the mouse position
        Vector2 direction = (mousePosition - transform.position).normalized;
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);

        // Clamp the player's position to the camera view
        float cameraHeight = 2f * mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;
        float cameraLeft = mainCamera.transform.position.x - cameraWidth / 2f + padding;
        float cameraRight = mainCamera.transform.position.x + cameraWidth / 2f - padding;
        float cameraBottom = mainCamera.transform.position.y - cameraHeight / 2f + padding;
        float cameraTop = mainCamera.transform.position.y + cameraHeight / 2f - padding;
        Vector2 position = transform.position;
        position.x = Mathf.Clamp(position.x, cameraLeft, cameraRight);
        position.y = Mathf.Clamp(position.y, cameraBottom, cameraTop);
        transform.position = position;
    }
}
