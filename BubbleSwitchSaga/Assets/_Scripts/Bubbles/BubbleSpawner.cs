using UnityEngine;

namespace _Scripts.Bubbles
{
    public class BubbleSpawner : MonoBehaviour
    {

        [SerializeField] private Bubble _bubblePrefab;
        
        public void SpawnNewBubble()
        {
            Instantiate(_bubblePrefab, new Vector2(2, 2), Quaternion.identity);
        } 
    }
}
