using UnityEngine;

public class TrackCamera : DefaultTrackableEventHandler {

    public Rigidbody rb;
    public GameObject playButton, panelPause;

    protected override void OnTrackingFound() {
        base.OnTrackingFound();
        rb.useGravity = true;

        Time.timeScale = 1;

        panelPause.SetActive(false);

        if (!IsInGame.isInGame)
            playButton.SetActive(true);
    }

    protected override void OnTrackingLost() {
        base.OnTrackingLost();
        rb.useGravity = false;
        playButton.SetActive(false);

        if (IsInGame.isInGame) {
            Time.timeScale = 0;
            panelPause.SetActive(true);
        }
    }

}
