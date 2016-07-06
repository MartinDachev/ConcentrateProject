using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using DatabaseContent;

namespace BouncingBallGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        //Define the variables
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont segoeUI36, segoeUILight14, segoeUI26, segoeUI12;
        Ball bigBall;
        Ball smallBall;
        GameObject hardmeter, horizontalLineLeft, horizontalLineTileRight, hardmeterArrow, yellowButton;
        GameObject showBulb, yellowBulb, redBulb;
        MouseState currentMouseState, pausedMouseState;
        Random r = new Random();
        GameState gameState = GameState.Paused;
        Texture2D backgroundTexture;
        Timer timer, velocityIncreaseTimer, velocityControlTimer, bulbIntervalTimer, bulbShowTimer;
        TimeSpan elapsedGameTime;
        KeyboardState oldKBState, currentKBState;
        Vector2 gameOverTextPosition, gameTimerTextPosition, gameScoreTextPosition, playAgainTextPosition, instructionsTextPosition;
        long currentSystemTicks;
        long lastSystemTicks;
        long bulbStartTicks;
        double currentSystemMilliseconds;
        int maxBulbScore = 1000;
        float minVelocity = 0.015F; // + 0.12F;
        float maxVelocity = 0.095F; // + 0.12F;
        const string gameOverText = "Край на играта!", timeSeparator = ":", playAgainText = "   Натиснете 'Space'\nза да играете отново.", instructionsText = " Натиснете\n 'Tab' за\nинструкции", firstPlayText = "   Натиснете 'Space'\nза да започнете играта.", pausedText = "   Натиснете 'Space'\nза да продължите играта.";
        StringBuilder elapsedGameTimeSB;
        string elapsedTimeText = "00:00:00", tmp;
        float velocityIncreaseValue = 0.007F;
        const int velocityIncreaseInterval = 5000;
        double gameScore = 0;
        int gameScoreFinal = 0;
        float originalArrowY;
        const float arrowIncrease = 7.2F;
        int numberOfIncrementApplied = 0;
        double bulbShowLength = 1000;
        bool bulbHandled = false;


        //Enum GameState to change states
        public enum GameState
        {
            Playing, Paused, FirstPlay, GameOver
        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1000;
            graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";
            //this.currentUser = currentUser;
        }

        //Method for small ball movement with mouse
        public void MoveWithMouse(Ball ball)
        {
            currentMouseState = Mouse.GetState();
            if (currentMouseState.X >= 0 && currentMouseState.X <= GraphicsDevice.Viewport.Width - ball.Texture.Width
                && currentMouseState.Y >= 0 && currentMouseState.Y <= GraphicsDevice.Viewport.Height - ball.Texture.Height)
            {
                ball.Position.X = currentMouseState.X;
                ball.Position.Y = currentMouseState.Y;
                ball.UpdateCenter();
            }
        }

        public string UpdateTimer(TimeSpan elapsedTime)
        {
            elapsedGameTime = elapsedGameTime.Add(elapsedTime);
            tmp = elapsedGameTime.ToString();
            return tmp.Substring(0, Math.Min(11, tmp.Length));
        }

        public void UpdateKBAndTime()
        {
            currentKBState = Keyboard.GetState();
            currentSystemTicks = DateTime.Now.Ticks - lastSystemTicks;
            currentSystemMilliseconds = currentSystemTicks / 10000.0;
            lastSystemTicks = DateTime.Now.Ticks;
        }

        public void HandleGameOver()
        {
            UpdateDatabase.AddBouncingBallScore(this.gameScoreFinal);
            bigBall.minVelocity = this.minVelocity;
            bigBall.maxVelocity = this.maxVelocity;
            bigBall.RandomVelocity(r);
        }

        public void HandleBulbIntervalTimerTick()
        {
            this.bulbStartTicks = DateTime.Now.Ticks;
            ShowRandomBulb();
            bulbIntervalTimer.Stop();
            bulbIntervalTimer.Reset();
            bulbShowTimer.Start();
        }

        public void HandleBulbShowTimerTick()
        {
            bulbShowTimer.Stop();
            bulbShowTimer.Reset();
            bulbIntervalTimer.RandomInterval(r);
            bulbIntervalTimer.Start();
            this.showBulb.IsActive = false;
            if (!this.bulbHandled)
            {
                this.gameScore -= 500;
                this.bulbHandled = false;
            }
        }

        public void IncreaseHardmeterArrow()
        {
            if (numberOfIncrementApplied < 20)
            {
                hardmeterArrow.Position.Y -= arrowIncrease;
                numberOfIncrementApplied++;
            }
        }

        public void ShowRandomBulb()
        {
            if (r.Next(0, 2) == 0)
            {
                this.showBulb = this.yellowBulb;
            }

            else
            {
                this.showBulb = this.redBulb;
            }
            this.showBulb.IsActive = true;
        }

        public void HandleIfBulbButtonsPressed()
        {
            if (currentKBState.IsKeyDown(Keys.LeftShift) && !oldKBState.IsKeyDown(Keys.LeftShift))
            {
                if (this.showBulb.Equals(yellowBulb))
                {
                    double bulbReactionTime = 200 / ((DateTime.Now.Ticks - this.bulbStartTicks) / 10000000.0);
                    this.gameScore += Math.Min((int)(bulbReactionTime), maxBulbScore);
                }
                else
                {
                    this.gameScore -= 500;
                }

                this.showBulb.IsActive = false;
                this.bulbHandled = true;
            }


            if (currentKBState.IsKeyDown(Keys.Space) && !oldKBState.IsKeyDown(Keys.Space))
            {
                if (this.showBulb.Equals(redBulb))
                {
                    double bulbReactionTime = 200 / ((DateTime.Now.Ticks - this.bulbStartTicks) / 10000000.0);
                    this.gameScore += (int)(bulbReactionTime);
                }
                else
                {
                    this.gameScore -= 500;
                }

                this.showBulb.IsActive = false;
                this.bulbHandled = true;
            }
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            HandleCollisions.viewport = this.GraphicsDevice.Viewport;
            // Initialization
            // TODO: use this.Content to load your game content here
            bigBall = new Ball(this.Content.Load<Texture2D>("bigCircle5"), new Vector2(100, 100), new Vector2(0.1F, 0.1F), 92.5F);
            smallBall = new Ball(this.Content.Load<Texture2D>("smallBall"), new Vector2(500, 350), new Vector2(0, 0), 21.5F);
            smallBall.Position = bigBall.Center;
            horizontalLineTileRight = new GameObject(this.Content.Load<Texture2D>("horizontalLineTile2"), new Vector2(this.GraphicsDevice.Viewport.Width - 100, 0));
            horizontalLineLeft = new GameObject(this.Content.Load<Texture2D>("horizontalLineTile2"), new Vector2(100, 0));
            hardmeter = new GameObject(this.Content.Load<Texture2D>("hardmeter2"), new Vector2(0, 0));
            hardmeter.Position = new Vector2(this.horizontalLineTileRight.Position.X + this.horizontalLineTileRight.Texture.Width
                                                                                     + (this.GraphicsDevice.Viewport.Width - this.horizontalLineTileRight.Position.X) / 2
                                                                                     - (hardmeter.Texture.Width / 2),
                                              this.GraphicsDevice.Viewport.Height - this.hardmeter.Texture.Height - 20);
            backgroundTexture = this.Content.Load<Texture2D>("background");
            hardmeterArrow = new GameObject(this.Content.Load<Texture2D>("Arrow"), new Vector2(this.hardmeter.Position.X + 29, this.hardmeter.Position.Y + 160));
            yellowBulb = new GameObject(this.Content.Load<Texture2D>("YellowBulb"), new Vector2(0, 0));
            yellowBulb.Position = new Vector2(this.horizontalLineLeft.Position.X / 2 - yellowBulb.Texture.Width / 2, 50);
            redBulb = new GameObject(this.Content.Load<Texture2D>("RedBulb"), yellowBulb.Position);
            yellowButton = new GameObject(this.Content.Load<Texture2D>("yellowButton5"), new Vector2(-3, this.GraphicsDevice.Viewport.Height - 90));
            instructionsTextPosition = new Vector2(2, this.GraphicsDevice.Viewport.Height - 70);
            showBulb = yellowBulb;
            showBulb.IsActive = false;
            segoeUI36 = this.Content.Load<SpriteFont>("segoeUI36");
            segoeUI26 = this.Content.Load<SpriteFont>("segoeUI26");
            segoeUILight14 = this.Content.Load<SpriteFont>("SegoeWP");
            segoeUI12 = this.Content.Load<SpriteFont>("segoeUI12");
            timer = new Timer();
            bulbIntervalTimer = new Timer();
            bulbIntervalTimer.MinIntervalTime = 2000;
            bulbIntervalTimer.MaxIntervalTime = 9000;
            bulbIntervalTimer.RandomInterval(r);
            bulbIntervalTimer.Start();
            bulbShowTimer = new Timer();
            bulbShowTimer.Interval = this.bulbShowLength;
            velocityIncreaseTimer = new Timer();
            velocityIncreaseTimer.Interval = velocityIncreaseInterval;
            velocityIncreaseTimer.Start();
            velocityControlTimer = new Timer();
            velocityControlTimer.Interval = 20;
            velocityControlTimer.Start();
            elapsedGameTime = new TimeSpan(0);
            elapsedGameTimeSB = new StringBuilder();
            timer.MinIntervalTime = 300;
            timer.MaxIntervalTime = 5000;
            timer.RandomInterval(r);
            timer.Start();
            bigBall.maxVelocity = this.minVelocity;
            bigBall.minVelocity = this.maxVelocity;
            bigBall.RandomVelocity(r);
            originalArrowY = this.hardmeter.Position.Y + 160;
            gameOverTextPosition = new Vector2(this.GraphicsDevice.Viewport.Width / 2 - 110, this.GraphicsDevice.Viewport.Height / 2 - 100);
            gameScoreTextPosition = new Vector2(920, 20);
            gameTimerTextPosition = new Vector2(this.GraphicsDevice.Viewport.Width / 2 - 75, 20);
            playAgainTextPosition = new Vector2(this.GraphicsDevice.Viewport.Width / 2 - 150, this.GraphicsDevice.Viewport.Height / 2 - 50);
            oldKBState = Keyboard.GetState();
            lastSystemTicks = DateTime.Now.Ticks;
            this.gameState = GameState.FirstPlay;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            UpdateKBAndTime();

            // Launch About Form if TAB is pressed
            if (currentKBState.IsKeyDown(Keys.Tab) && !oldKBState.IsKeyDown(Keys.Tab))
            {
                this.gameState = GameState.Paused;
                pausedMouseState = Mouse.GetState();
                BouncingBallAboutForm.AboutBouncingBall aboutForm = new BouncingBallAboutForm.AboutBouncingBall();
                aboutForm.Show();
            }

            // Change small ball position when game starting or game resumed
            if (this.gameState == GameState.FirstPlay || this.gameState == GameState.Paused)
            {
                if (currentKBState.IsKeyDown(Keys.Space) && !oldKBState.IsKeyDown(Keys.Space))
                {
                    gameState = GameState.Playing;
                    Mouse.SetPosition((int)smallBall.Position.X, (int)smallBall.Position.Y);
                }
            }


            // Main update logic when playing
            if (this.gameState == GameState.Playing)
            {

                // Adding new new elapsed times to Timers
                timer.ElapsedTime += currentSystemMilliseconds;
                velocityIncreaseTimer.ElapsedTime += currentSystemMilliseconds;
                velocityControlTimer.ElapsedTime += currentSystemMilliseconds / 1000;
                bulbIntervalTimer.ElapsedTime += currentSystemMilliseconds;
                bulbShowTimer.ElapsedTime += currentSystemMilliseconds;
                
                // Check if Timer Tick occured
                if (bulbIntervalTimer.ElapsedTime >= bulbIntervalTimer.Interval)
                {
                    HandleBulbIntervalTimerTick();
                }

                if (bulbShowTimer.ElapsedTime >= bulbShowTimer.Interval)
                {
                    HandleBulbShowTimerTick();
                }

                if (velocityControlTimer.ElapsedTime >= velocityControlTimer.Interval)
                {
                    this.velocityIncreaseValue *= 0.95F;
                    velocityControlTimer.Reset();
                }

                elapsedGameTime.Add(gameTime.ElapsedGameTime);

                // If Tick occured, new random velocity for the Big ball
                if (timer.ElapsedTime >= timer.Interval)
                {
                    timer.Reset();
                    timer.RandomInterval(r);
                    bigBall.RandomVelocity(r);
                }

                // If Tick occured, increase velocity bounds for the Big ball
                if (velocityIncreaseTimer.ElapsedTime >= velocityIncreaseTimer.Interval)
                {
                    velocityIncreaseTimer.Reset();
                    bigBall.IncreaseVelocityLimits(velocityIncreaseValue);
                    IncreaseHardmeterArrow();
                    //System.Threading.Thread.Sleep(2000);
                }
                
                // Update balls' positions
                bigBall.NextPosition(currentSystemMilliseconds);
                MoveWithMouse(smallBall);
                //smallBall.Position = bigBall.Center;
                //smallBall.UpdateCenter();


                // Check if collision occured
                HandleCollisions.WallCollision(bigBall);
                HandleCollisions.WallCollisionHorizontalRight(bigBall, horizontalLineLeft);
                HandleCollisions.WallCollisionHorizontalLeft(bigBall, horizontalLineTileRight);

                // If the balls collided, game over
                if (HandleCollisions.BallCollision(bigBall, smallBall))
                {
                    this.gameState = GameState.GameOver;
                    this.HandleGameOver();
                }

                // Update score and text
                this.elapsedTimeText = UpdateTimer(gameTime.ElapsedGameTime);
                this.gameScore += bigBall.Speed * gameTime.ElapsedGameTime.TotalMilliseconds;
                this.gameScoreFinal = (int)(gameScore / 10);
            }

            else if (this.gameState == GameState.Paused || this.gameState == GameState.GameOver)
            {
                // Restart or resume game if Space is down
                if (currentKBState.IsKeyDown(Keys.Space) && !oldKBState.IsKeyDown(Keys.Space))
                {
                    gameState = GameState.Playing;
                    Mouse.SetPosition((int)this.bigBall.Center.X, (int)this.bigBall.Center.Y);
                    elapsedGameTime = new TimeSpan();
                    this.gameScore = 0;
                    this.velocityIncreaseTimer.Reset();
                    this.bulbIntervalTimer.Reset();
                    this.bulbShowTimer.Reset();
                    hardmeterArrow.Position.Y = originalArrowY;
                }
            }

            // If bulb is showed, check for button press
            if (this.showBulb.IsActive)
            {
                HandleIfBulbButtonsPressed();
            }

            // OldKBState becomes currentBKState for the next update
            oldKBState = currentKBState;
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, this.GraphicsDevice.Viewport.Width, this.GraphicsDevice.Viewport.Height), Color.LightSkyBlue);
            spriteBatch.Draw(smallBall.Texture, smallBall.Position, Color.White);
            spriteBatch.Draw(bigBall.Texture, bigBall.Position, Color.White);
            spriteBatch.Draw(hardmeter.Texture, hardmeter.Position, Color.White);

            if (showBulb.IsActive)
            {
                spriteBatch.Draw(showBulb.Texture, showBulb.Position, Color.White);
            }

            spriteBatch.Draw(hardmeterArrow.Texture, hardmeterArrow.Position, Color.White);
            spriteBatch.Draw(horizontalLineTileRight.Texture, new Rectangle((int)horizontalLineTileRight.Position.X, (int)horizontalLineTileRight.Position.Y, horizontalLineTileRight.Texture.Width, this.GraphicsDevice.Viewport.Height), Color.White);
            spriteBatch.Draw(horizontalLineLeft.Texture, new Rectangle((int)horizontalLineLeft.Position.X, (int)horizontalLineLeft.Position.Y, horizontalLineLeft.Texture.Width, this.GraphicsDevice.Viewport.Height), Color.White);
            spriteBatch.DrawString(segoeUILight14, elapsedTimeText, gameTimerTextPosition, Color.Yellow);
            spriteBatch.DrawString(segoeUILight14, (this.gameScoreFinal.ToString()), gameScoreTextPosition, Color.Yellow);
            spriteBatch.DrawString(segoeUI12, instructionsText, instructionsTextPosition, Color.Yellow);
            

            // Drawing the appropriate text for the different game states

            if (this.gameState == GameState.Paused)
            {
                spriteBatch.DrawString(segoeUILight14, pausedText, gameOverTextPosition, Color.Yellow);
            }

            if (this.gameState == GameState.FirstPlay)
            {
                spriteBatch.DrawString(segoeUILight14, firstPlayText, gameOverTextPosition, Color.Yellow);
            }

            if (this.gameState == GameState.GameOver)
            {
                spriteBatch.DrawString(segoeUILight14, gameOverText, gameOverTextPosition, Color.Yellow);
                spriteBatch.DrawString(segoeUILight14, playAgainText, playAgainTextPosition, Color.Yellow);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}