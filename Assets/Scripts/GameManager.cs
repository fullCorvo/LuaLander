using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;

    private void Start()
    {
        Lander.Instance.OnCoinPickup += Instance_OnCoinPickup;
        Lander.Instance.OnLanded += Instance_OnLanded;
    }

    private void Instance_OnLanded(object sender, Lander.OnLandedEventArgs e)
    {
        AddScore(e.landingScore);
    }

    private void Instance_OnCoinPickup(object sender, System.EventArgs e)
    {
        AddScore(500);
    }

    public void AddScore(int addScoreAmount)
    {
        score += addScoreAmount;
        Debug.Log("Score: " + score);
    }
}
