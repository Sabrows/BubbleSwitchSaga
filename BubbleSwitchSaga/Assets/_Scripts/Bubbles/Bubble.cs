using UnityEngine;

namespace _Scripts.Bubbles
{
    public class Bubble : MonoBehaviour
    {
        public BubbleColor bubbleColor;

        public Bubble(int bubbleIndex)
        {
            BubbleIndex = bubbleIndex;
        }

        public int BubbleIndex { get; private set; }

        private SpriteRenderer _spriteRenderer;

        /// <summary>
        /// 
        /// </summary>
        private void OnEnable()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            SetBubbleColor();
        }

        /// <summary>
        /// Sets the sprite color according to the set bubble color.
        /// </summary>
        private void SetBubbleColor()
        {
            switch (bubbleColor)
            {
                case BubbleColor.RED:
                    _spriteRenderer.color = Color.red;
                    break;
                case BubbleColor.GREEN:
                    _spriteRenderer.color = Color.green;
                    break;
                case BubbleColor.BLUE:
                    _spriteRenderer.color = Color.blue;
                    break;
                case BubbleColor.YELLOW:
                    _spriteRenderer.color = Color.yellow;
                    break;
            }
        }

        public void DestroyBubble()
        {
            //
        }
    }

    /// <summary>
    /// Defined bubble colors.
    /// </summary>
    public enum BubbleColor
    {
        RED,
        GREEN,
        BLUE,
        YELLOW
    }
}