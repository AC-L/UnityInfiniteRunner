[Prototype Game and Design Documentation: The Unknown
Dungeon.]{.underline}

![](media/image1.png){width="1.8333333333333333in"
height="1.7916666666666667in"}[Synopsis]{.underline}

The game is set in deep-space on a planet far away from earth. The
atmosphere is weak and the gravity is much lower than earths.

Figure 1 shows our protagonist. Its name and gender are currently
unknown. It suddenly woke up with no recollection of its past. It is
trapped in a dangerous and tries to survive long enough so it can
discover the truth behind its past.

[Goal]{.underline}

The goal of the game is simply to survive and collect points. You gain
points over time for surviving and for collecting specific in-game
items. Some items give more points than others.

The player starts off with 100 health, coming into contact with hazards
reduces their health. And when they lose all 100 of their health. The
game ends and their score are shown.

The game is an endless runner, meaning it only ends when the player dies
or when the restart button is pressed.

![](media/image3.png){width="6.25in" height="3.8333333333333335in"}There
are no real rules to the game. But there are restrictions. As show by
Figure 2, the player is trapped in, surrounded by the floor/ceiling as
well as two rows of saws. There is no escape. These golden saws move
along the dungeon and sweep it of any life. It is unfortunate that the
player is stuck here.

[In Game Items and Hazards.]{.underline}

Figure 3 shows various in game objects and their effects.

  [Object]{.underline}                                                 [Picture]{.underline}                                                                [Description]{.underline}
  -------------------------------------------------------------------- ------------------------------------------------------------------------------------ -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Gold Coin                                                            ![](media/image5.png){width="0.7708333333333334in" height="0.7708333333333334in"}    Common Gold Coins. Gives the player 2 points to add to their score.
  Diamond                                                              ![](media/image6.png){width="0.7395833333333334in" height="0.7395833333333334in"}    Rare Blue Diamonds. Highly valuable. Gives the player 50 points to add to their score.
  Health Bonus                                                         ![](media/image7.png){width="0.7916666666666666in" height="0.7916666666666666in"}    Life Force from an unknown source. Gives the player 20 health. Also allows the player to over-heal. This is going past 100 health. This is the only way to increase health.
  Golden Saw                                                           ![](media/image8.png){width="0.8541666666666666in" height="0.8541666666666666in"}    High powered saws that spin extremely fast. Reduces the players health by 50 on hit and push the player away.
  Bronze Saw                                                           ![](media/image9.png){width="0.5208333333333334in" height="0.5208333333333334in"}    Medium powered saws that spin extremely fast. Reduces the players health by 20 on hit and push the player away. Destroyed on hit.
  Spikes                                                               ![](media/image10.png){width="0.6666666666666666in" height="0.6666666666666666in"}   Sharp titanium spikes. Usually found along the walls and Ceiling of the area. Reduces the players health by 10 on hit and push the player away.
  Figure 3: Table showing various in-game objects and their effects.                                                                                        

[Characters]{.underline}

-   The only character in the game is the aforementioned unknown.

-   The character is controlled by the player.

-   It is a strange being that does not need oxygen.

-   It has a weak levitation ability. This means it has control of where
    it goes, but cannot easily maintain a fixed position due to the
    effect of gravity.

-   This is reflected by the player movement in-game.

-   The character has base 100 health and a mass of 1.

[Physics and parameters]{.underline}

[Physics and parameters: Player Physics]{.underline}

The player is able to move in all directions of the 2D plane. However,
the movement speed depends on what direction they are moving in.

-   The controls are W, A, S and D. The direction these move the player
    is of the standard layout. W is Up, S is Down, A is Backwards and D
    is Forwards.

-   Moving forward moves the player much faster than moving backwards.

-   Moving up and down moves the player at the same rate as each other.
    But is slower compared to moving right and faster compared to moving
    back.

-   Gravity is still in effect. So, the player has to take this into
    account when moving in the air.

[Physics and parameters: Hazard Physics]{.underline}

-   As explained earlier in this document, the hazards move the player
    when contact is made.

-   This is unpredictable and even has the ability to propel the player
    into addition hazards.

-   Therefore, hazards are designed to increase in strength and risk
    when more are grouped together.

-   ![](media/image11.png){width="6.25in" height="3.75in"}Figure 4 gives
    an example of this. If the player come in contact with the top of
    the saw, they will most likely be propelled along the spikes as
    well. Causing massive damage.

[Physics and parameters: Powerup Physics]{.underline}

-   Powerups are destroyed on contact.

-   Unlike hazards, they do not move the player on contact.

[Game Flow]{.underline}

The difficulty curve has been designed to be fairly shallow or flat in a
physical sense. But much steeper in a mental sense.

As the game goes on there are many unavoidable instances where there is
a high chance the player takes damage. Health powerups are rare and so
as the game goes on, the appearance of risk may seem mentally higher.

[Game flow: Skill Cap]{.underline}

-   The skill cap comes from two areas.

-   Mechanical skill- The ability to effectively control the player. Due
    to gravity, controlling the vertical movement is more difficult.
    Travelling in a fairly straight line in the air is difficult.

-   Decision making- There will be multiple possible paths. The player
    must weigh up the pros and cons of each path in real time, to decide
    which one they will take.

-   ![](media/image13.png){width="6.268055555555556in"
    height="3.540277777777778in"}Figure 5 shows this. The player has two
    possible paths. One is riskier, due to the location of the spikes,
    but allows the player to collect more points. Both paths are narrow
    and require significant control of the character to pass through
    unharmed.

[User Interface]{.underline}

The user interface is made up of 3 elements. Health, Score and a restart
button. Health and Score display their current respective values.
Restart resets the entire game back to where is began. It will work
regardless of if the player is alive or not.

[Level requirements]{.underline}

There is only one continuous level. The items are revealed as soon as
they spawn after the start of the game. But the in-game
objects/environment are all random or semi-random so no one level is the
same.

[Prototype Instructions]{.underline}

When the game is opened it starts immediately. You are spawned in on the
ground. There is a brief safe area before the danger. There is also
gravity.

Your goal is to survive and collect as much 'Score' as possible.

Move forward with D. Move Backwards with A. Move up with W. Move Down
with D or by letting gravity to bring you down.

You have 100 health to start. If it reaches 0 you die. Avoid this where
possible.

![](media/image5.png){width="0.26319444444444445in"
height="0.2708333333333333in"}![](media/image6.png){width="0.2916666666666667in"
height="0.2263888888888889in"}Moving your player into these gives you
score. [ ]{.underline} Blue diamonds are more valuable than coins.
Prioritise these where ever possible.

![](media/image7.png){width="0.2604166666666667in"
height="0.20833333333333334in"}Moving into these gives you health.

![](media/image14.png){width="0.21875in"
height="0.12291666666666666in"}![](media/image15.png){width="0.17708333333333334in"
height="0.17708333333333334in"}Moving into these deals medium amounts of
damages and propels you away. Be cautious of being propelled from one
hazard into another. This can mean massive damage.

![](media/image16.png){width="0.2604166666666667in"
height="0.2604166666666667in"}Moving into these deals enormous damage
and propels you away. Avoid contact with these at all costs.

When moving it is advised to constantly toggle the movement buttons in
order to move between obstacles more precisely. Your use of vertical
movement is most important.

Sometimes you may not be able to avoid all hazards. Remember it is
possible to destroy orange saws on contact. Use this to cut your losses
if needed.

Please note, I didn't just copy and alter the YouTube tutorials
reference. They were used mostly for reference and to understand how
certain functions work. For example, the use of Quaternion.identity and
Instantiate. My work is heavily based on the game's labs 1 and 2.

References
==========

Blackthornprod. (2018). *HOW TO MAKE A SIMPLE GAME IN UNITY - ENDLESS
RUNNER - \#2*. Retrieved from Youtube:
https://www.youtube.com/watch?v=FVCW5189evICharger Games. (2015).
*34.Unity Coroutines with IEnumerator & WaitForSeconds - Unity C\#
Scripting Tutorial*. Retrieved from YouTube:
https://www.youtube.com/watch?v=oNC6UtxMXcADINV STUDIO. (2018). *Dynamic
Space Background Lite.* Retrieved from unity Asset Store:
https://assetstore.unity.com/packages/2d/textures-materials/dynamic-space-background-lite-104606Flintham,
M. (2019). *Games Lab1.* Retrieved from Nottingham Moodle:
https://moodle.nottingham.ac.uk/pluginfile.php/5128206/mod\_resource/content/0/g53gam\_lab\_01.pdfFlintham,
M. (2019). *Games Lab2.* Retrieved from Nottingham Moodle:
https://moodle.nottingham.ac.uk/pluginfile.php/5135882/mod\_resource/content/0/g54gam\_lab\_02\_updated.pdfgamesplusjames.
(2015). *Youtube*. Retrieved from Unity Endless Runner Tutorial :
https://www.youtube.com/watch?v=yiXlPP8jOvs&list=PLiyfvmtjWC\_XmdYfXm2i1AQ3lKrEPgc9-&index=4&pbjreload=10KenneY.
(2019). *Simplified Platformer Pack.* Retrieved from KenneY:
https://www.kenney.nl/assets/simplified-platformer-packUnity
Technologies. (2019, April 15th). *Unity Manual*. Retrieved from unity
DOCUMENTATION: https://docs.unity3d.com/Manual/index.htmlZotov, A.
(2017, April 13th). *How to add a score counter into your Unity 2D game?
Easy.* Retrieved from Youtube:
https://www.youtube.com/watch?v=QbqnDbexrCw
