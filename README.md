# COMP4024_CW

## Project
### Math Olympiad
> A 2D plat former educational game for 7-10-year-old children, to aid in SAT preparation. 

#### Project Goals 
- To create a game for children under the age of 10. The timeline for this project is around four and a half weeks (from 10th February 2023 to 13th March 2023). 

#### Project plan (MVP) 
  - The storyline of the game: 
    - Maths game in which the player must cross hurdles/checkpoints by solving maths problems before losing all their lives. 
    - Maths questions include addition, multiplication, subtraction, division, fractions, decimals, and percentages.  
  - Purpose of the game: 
    - Maths Olympiad: A revision tool for children leading up to their Year 6 SATs 

### Game Plan
  - The game will be divided into stages.  
    - Example: stage 1 will have 3 questions, stage 2 will have 5 questions, etc.  
  - The player will have a score depending on the number of questions solved and the cherry’s collected along the way     to the question checkpoint. 
  - Players will not lose points for incorrect answers but will lose lives if answered incorrectly or if they collide with the hurdles. 
  - Score Counter: Based on the number of cherries collected and checkpoints (answering the questions). Correct answer = 3 points. Cherry = 1 point. No point deduction for the incorrect answer (this will be part of the future scope). 
 
## Requirements 
The following section entails requirements that are MUST and SHOULD. Where MUST are mandotary and SHOULD are considred potenital features.
#### Player
- MUST be able to walk left 
- MUST be able to walk right 
- MUST be able to jump 
- MUST be able to reach checkpoints
- MUST be able to avoid obsticales 
- SHOULD be able to wall jump
- SHOULD be able to fight 
- SHOULD have lives system

#### Environment
- MUST include obstacles 
- MUST include checkpoints
- MUST include question points 
- MUST include floor tile runway
- MUST include collectables (cherries)
- MUST including start and end points
- SHOULD include mobs to fight

#### In-game play
- MUST be able to select answer to questions 
- MUST have a scoring system 
- MUST be able to collect items
- MUST be able to score points in some format 
- MUST be able to show questions to user
- SHOULD be able to lose score when giving incorrect answer
- SHOULD be able to lose lives when running into fire
- SHOULD be able to lose lives when giving incorrect answer
- SHOULD be able to pause and resume the game

#### Levels
- SHOULD include multiple levels 
- SHOULD be able to go to next level

#### User Interface
- MUST have home page (including start, settings, & quit)
- MUST have Pause page (including continue, restart, & back to menu)
- MUST have completion page (including main menu, next level & score)

## Game-play snapshots
![MainMenu](/uploads/1da4f09704bde6ea5351aa9a855c432c/MainMenu.png)
![Gameplay-1](/uploads/5af80add3992970c2fff0105efb56b33/Gameplay-1.png)
![Gameplay_-2](/uploads/3d6394042622f6d5a958abb2e2bf224c/Gameplay_-2.png) 

## Instructions 
Choose a difficulty level
Select Play button to start 

You will use the keyboard to move your character: 
- **Left key** = move left
- **Right key** = move right
- **Spacebar** = jump
- **E** = open up question panel (next to question object)
- **Q** = quit question panel (next to question object)
- **Esc** = Open up main menu 

Navigate your player through each level by crossing hurdles and solving questions 

You have 3 lives. You will lose a life if you a) answer the question incorrectly or b) the character falls 

You can pause or quit the game at anytime using  the Pause and Quit buttons 


## Testing

### Character Test

| Inputs  |Input Type| Expect Result | Unit Test Pass/Fail | User Test Pass/Fail
| ------------- | ------------- | ------------- | ------------- | ------------- |
| Left Key | Keys  | Player object moves left | Pass | Pass 
| Right Key | Keys  | Player object moves right | Pass | Pass
| Space Key | Keys  | Player object moves up | Pass | Pass
| Space Key x2 | Keys  | Player object moves up twice (double jump) | N/A | Fail
| PLayer spawn | Mouse | When game starts player spawns in spawning point | N/A | Pass


### Arithmetic Test

| Inputs  |Input Type| Expect Result | Unit Test Pass/Fail | User Test Pass/Fail
| ------------- | ------------- | ------------- | ------------- | ------------- |
| Click | Mouse  | User clicks correct addition answer | Fail | Pass
| Click | Mouse  | User clicks correct subtraction answer | Fail | Pass
| Click | Mouse  | User clicks correct division answer | Fail | Pass 
| Click | Mouse  | User clicks correct multiplication answer | Fail | Pass


### Environment Test
| Inputs  |Input Type| Expect Result | Unit Test Pass/Fail | User Test Pass/Fail
| ------------- | ------------- | ------------- | ------------- | ------------- |
| Walk to question point | Keys  | Answer Window pop up | N/A | Pass
| Walk into fire | Keys | -1 Score |  N/A | Pass 
| Walk to exit checkpoint | Keys | Pop up window | N/A | Pass


### UI testing
| Inputs  |Input Type| Expect Result | Unit Test Pass/Fail | User Test Pass/Fail
| ------------- | ------------- | ------------- | ------------- | ------------- |
| Click correct answer | Mouse | if correct answer window dissaperes and +3 score points | N/A | Pass 
| Click wrong answer | Mouse | display incrroect text | N/A | Pass 
| Press esc | Keys | Show Menu pop-up | N/A | Pass
| Click Play Again | Mouse | Replay current level | N/A | Pass
| Click Restart | Mouse | Replay current level | N/A | Pass
| Click on Next Level | Mouse | move to next level | N/A | Fail
| Click Return To Main Menu | Mouse | return to main menu | N/A | Pass
| Click Quit | Mouse | close game | N/A | Fail
| Click Question Button | Mouse | give Correct or Incorrect response | N/A | Pass

## Contributors 
```
Project Manager: Arpita 
Technical Lead: Arpita 
Programmer (Implementation): Sahil, Paul
Secondary Programmer (Backup): Arpita
Researcher: Elise, Shan Li, Lainya
Tester: Sahil, Paul
Documentation: Elise, Shan Li, Lainya
```

## Project Status
✅ Finished ⏳ In-Progress 
✅ Started \
✅ Planning Stage \
✅ Development Stage \
✅ Testing \
✅ Documentation\
✅ Completed 

### Reference work
![TestMaps - Shan Li](https://projects.cs.nott.ac.uk/-/ide/project/efysr3/comp4024_cw/edit/picture/-/WechatIMG192.png)
