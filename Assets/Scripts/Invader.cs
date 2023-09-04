using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Invader : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite[] animationSprites = new Sprite[0];
    public float animationTime = 1f;
    public int animationFrame { get; private set; }
    public int score = 10;
    public System.Action<Invader> killed;
    public AudioSource frame1;
    public AudioSource frame2;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = animationSprites[0];
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), animationTime, animationTime);
    }

    private void AnimateSprite()
    {
        animationFrame++;
        //Debug.Log(animationFrame);

        //if (animationFrame == 1) { frame1.Play(); }
        //if (animationFrame == 2) { frame2.Play(); }
        // Loop back to the start if the animation frame exceeds the length
        if (animationFrame >= animationSprites.Length) {
            animationFrame = 0;
        }

        spriteRenderer.sprite = animationSprites[animationFrame];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Laser")) {
            killed?.Invoke(this);
        }
    }

}
