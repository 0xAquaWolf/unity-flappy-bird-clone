using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Vector3 direction;

    public Sprite[] sprites;
    private int spriteIndex;

    public float gravity = -9.8f;

    public float strength = 5f;

    private void Awake() // this is called when the object is intialized
    {
        Debug.Log("Awake Lifecycle function");

        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log($"SpriteRender > {spriteRenderer}");
    }

    private void Start()
    {
        Debug.Log("Start Lifecycle function");
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // Mouse List => 0 = Left btn, 1 = Right btn, 2 = middle btn
        {
            direction = Vector3.up * strength;
        }

        // Basic tounch input controls
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Debug.Log(touch);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }

        // Debug.Log($"Player Direction: {direction}");
        // Debug.Log($"Game Gravity: {gravity}");
        // Debug.Log($"Time.deltaTime {Time.deltaTime}");

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        print($"Direction.y: {direction.y}");

    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        spriteRenderer.sprite = sprites[spriteIndex];

    }
}
