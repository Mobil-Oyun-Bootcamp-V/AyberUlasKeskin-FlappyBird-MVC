using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Events;
namespace MVC
{
    
    public class PlayerController
    {
        private bool isDead;
        
         
         PlayerView _view;
         PlayerModel _model;
         
            
        public PlayerController(PlayerView view)
        {
           
            _view = view;
           
           
           _view.Jump += Jump;
           _view.Dead += Dead;
           _view.Score += Score;
           _model = new PlayerModel();
        }

         void Jump()
        {
           
            _view._value= _model.value ;
            Debug.Log("jump");
          
            
        }

         void Dead()
        {
            
            Time.timeScale = 0;
            Debug.Log("dead");
            
            isDead = true;
           _view.DeathScreen.SetActive(true);
        }

        void Score()
        {
          _view.managerGame.UpdateScore(); 
            
        }
    }
}

