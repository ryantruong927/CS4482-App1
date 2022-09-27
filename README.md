# CS4482-App1

Based on Unity Learn's Ruby's Adventure tutorial (https://learn.unity.com/project/ruby-s-2d-rpg).

I modified the tutorial by adding a simple AI to the enemy that makes it follow the player when they get within the radius of their field of view. This FOV is determined by a CircleCollider2D set to trigger, where only the player can trigger the enemy's chasing event if they enter their field of view. The enemy is also limited to seeing only in front of it and will continue to chase the player for a defined amount of time after losing sight of the player (when the player exits the enemy's FOV). The enemy's speed when chasing can also be changed.

A smaller modification I made was creating a parent controller class for characters to inherit from, allowing easy addition of extra characters.
