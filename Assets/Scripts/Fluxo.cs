using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class Fluxo : MonoBehaviour {
        public LevelBuilder m_LevelBuilder;
        private Player m_Player;

        public GameObject m_CanvasMenu;
        public GameObject m_CanvasCredito;
        public bool is_tutorial;

	public void CarregarFase1()
    {    
        SceneManager.LoadSceneAsync ("MainScene");
        // m_LevelBuilder.Build();
        m_Player = FindObjectOfType<Player>();
    }

    public void Creditos()
    { 
       m_CanvasMenu.SetActive(false);
       m_CanvasCredito.SetActive(true);
    }

    public void ReturnMenu() 
    { 
        m_CanvasCredito.SetActive(false);
        m_CanvasMenu.SetActive(true);
    }

    private void Leave() 
    {
        Application.Quit ();
    }
}