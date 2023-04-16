# Explanation
In this project I changed the spaceship game from the lesson.
I made the option of having 3 lives, and when you have 0 lives (each time you have a collision with a spaceship your lives count drops by one) the game is over.
I made a heart that will spawn randomly and will reset the lives back to 3 when the player has a collision with him.
In addition, I used the arrow option from "ToNextLevel" to just re-center the spaceship. 
## Scripts
### PlayerSpaceship
1. LivesTrigger2D: responsible for the droping the lives and checks whether there are 0 lives left.

### LivesCount
1. LivesCountField: responsible for presenting the updated current lives.

### Heart
1. RestLives: responsible for reseting the lives count when a collision happens.
