using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Animator animator;

    private float alpha = 0;
    private Color currentColorText;
    private Color currentColotSprite;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void Start()
    {
        currentColorText = text.color;
        currentColotSprite = spriteRenderer.color;
    }

    public void ActivateFinalScreen()
    {
        SetAlpha();
        gameObject.SetActive(true);
        animator.SetBool("StartFadeIn", true);
    }

    private void SetAlpha()
    {
        currentColorText.a = alpha;
        currentColotSprite.a = alpha;

        text.color = currentColorText;
        spriteRenderer.color = currentColotSprite;
    }

}
