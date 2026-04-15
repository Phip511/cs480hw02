# cs480hw02
Author: Peyton

Note: Most of the changes here are tied to the gargoyle as it felt less visually there compared to the ghost (ghost is easy to see, gargoyle isn't)

- Added dot product functionality to enemies that use the observer script. Now the scope of the visual can be changed according to the view threshold value. Example values here below
    - 0.3 = wider vision cone
    - 0.5 = moderate vision cone (what it was before this change)
    - 0.7 = narrow vision cone

- Created DangerLight.cs script that uses Vector3.Distance and Mathf.Lerp to smoothly adjust a gargoyle light’s intensity based on how close the player is.
    - first gargoyle in main room has custom settings so that it is very obvious that it is working

- Created GargoyleParticleTrigger.cs script that creates a burst particle effect when a player is getting close to an enemy (serves as another warning beyond the glow)

- Added a stone sliding sfx to the Gargoyle, similar to the particle effect, where it only plays once a player reaches a distance threshold.


