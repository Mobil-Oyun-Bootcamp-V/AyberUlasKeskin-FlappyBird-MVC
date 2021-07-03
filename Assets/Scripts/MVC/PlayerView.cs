using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
namespace MVC
{
    public class PlayerView : MonoBehaviour
    {
        
        public UnityAction Jump;
        public UnityAction Dead;
        public UnityAction Score;
        public GameManager managerGame;
        public GameObject DeathScreen;

        
        public Rigidbody2D _rb2D;
        public float _value;
        private void Awake()
        {
            _rb2D = GetComponent<Rigidbody2D>();
        }
     
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
              
                Jump?.Invoke(); 
                _rb2D.velocity = Vector2.up * _value;
               
            }
        }

     
         void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name == "ScoreArea")
            {
               // managerGame.UpdateScore(); 
              Score?.Invoke();
            }
        }

         void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "DeathArea")
            {
                Dead?.Invoke();
                //isDead = true;
                
               // DeathScreen.SetActive(true);
            }
        }
   
    }
}