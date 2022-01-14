# CSE-3902 Zelda Game Sprint 4
## New feature
* Use bomb to open a door on the wall
* Limit player vision. Clouds cover the room, need to use candle fire to clean it
* Random events. WallMaster appears when link comes close
* Puzzle elements. Link can push blocks to enter the closed zone in the room
* The number of heart container is the upper limit of blood that link can have. Heart container number decreases when link collides with yellow/green dragon directly
* Add items blue portion and blue ring. Blue portion restore the number of heart container by one and blue ring can protect link from getting harm by enemies for about 10 seconds. Link will also get damaged if colliding with dragon's fire even with blue ring
* NPC communicates with link
* Green dragon will leave a Heart and Yellow dragon will leave a Key when they die
* Green dragon's fire can spread into three directions
* Link attacks in damaged mode
* Wall Master wiil throw link back to the first room
* Link will cause reduced damage to enemies when he gets damaged

## Major changes to the structure
* Sprite Factories
* Sprite classes condensation
* Inventory class encapsulation
* Use one IGameState object to keep track of the state

## How to play 

#### There are five Game States includs Start State, Play State, Pause State, Lose State and Win State. The state will be alternated among all five based on Link's behavior. In the Play State, Link has initial 12 blood drops once the game is began. Each room has been designed differenly with various enemies which cause Link to drop his blood variously. Link's position is shown on both the inventory bar and the inventory room through the game. And the whole map and TriForce Piece's location will appear only by picking up the corrsponding item. Link can pick up items where each of them has its unique functionality as listed below: 
* Heart: Link gains one drop of blood. Link can only pick up "Heart" when his blood is less than 12.
* Key: Link can use it to open the door. 
* Clock: freeze all moving objects in all the rooms
* Map: Show the level map both on the game bar and inventory screen
* Compass: Show the location of TriForce Pieces on the map only when item Map is collected
* Yellow Diamond: Some of dead enemies will turn into a diamond for Link to collect. Link can use it as money
* Weapon: Boomerang, Bow, and Candle can be purchased in Merchandise room with corrsponding price which is the number of yellow Diamonds. There is no need to purchase a bomb, it can be picked up in any room.
 
#### Start State
* Press "S" to start a game, switch to the Play State
* Press "Esc" to quit the game
#### Play State
* All enemies and items appear in the first room. Link can pick up items by touching them. To unlock the door, he has to pick up the key first. At the same time, Link needs to avoid enemies to avoid damage or attack enemies to destory them. Link needs to collect three triforce piece in order to switch to the win state
* Press "Z" and "N" to attack
* Press "1" to use the wooden sword as the defalut weapon
* Press "2" to use the weapon from "Item B" box locates at the game bar
* Press "I" to switch to Inventory room and "R" to switch back
* In the Inventory room, the weapons that being purchased will appear in the rectangle box on the top. Use "Up Arrow", "Down Arrow", "Left Arrow", or "Right Arrow" to traverse the weapons. Press "Enter" to select the weapon. Link can only select one per time, the selected weapon will appear in "item B" box
* Press "R" to switch back to Play room from Inventory room
* Press "Q" to switch back to the Start State
* Press "P" to pause the game from Play State
* Switch to Win State once Link collects three TriForce Pieces
* Switch to Lose State once Link drops all his blood
* Press "Esc" to quit the game

#### Pause State
* Press "R" to switch back from Pause State to Play State 
* Press "Esc" to quit the game

#### Win State
* Press "R" to restart a game
* Press "Esc" to quit the game 
#### Lose State
* Press "R" to restart a game
* Press "Esc" to quit the game

#### Game Walkthrough 
* Kill the yellow dragon in room17 to get the key. Use key to open the door in room1, then buy candle in room2 and grab map in room3
* The compass is in the room12. Once you get the compass and the map, you will know where to go to collect triforce pieces
* Candle will be used to fire the clouds in room18
* One block can be pushed away to enter the closed zone in room5
* You can use bomb to open a door on the wall in room 7,8,9,11
* Wall masters will appear when you get close to them and throw you back to room1

 
### Future Improvement and Implantation:
* Encapsulate LinkCollisionHandler class
  

### Unresolved warnings:  
* CA1822 (Member StayPosition doesn't access instance data and can be marked as static at LinkCollisionHandler.cs)
* CA1040 (empty interface at IitemState)

### Dungeon Map and Room Number:
![](Dungeon_Map.jpg)
