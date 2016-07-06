using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace BouncingBallGame
{
    public static class HandleCollisions
    {
        public static Viewport viewport;
        public static void WallCollision(Ball ball)
        {
            if (ball.Position.X + (ball.Texture.Width / 2 - ball.Radius) <= 0)
            {
                ball.Position.X = 0 - (ball.Texture.Width / 2 - ball.Radius);
                ball.Velocity.X = Math.Abs(ball.Velocity.X);
            }
            else if (ball.Position.X + (ball.Texture.Width / 2 + ball.Radius) >= viewport.Width)
            {
                ball.Position.X = viewport.Width - (ball.Texture.Width / 2 + ball.Radius);
                ball.Velocity.X = Math.Abs(ball.Velocity.X) * -1;
            }

            if (ball.Position.Y + (ball.Texture.Height / 2 - ball.Radius) <= 0)
            {
                ball.Position.Y = 0 - (ball.Texture.Height / 2 - ball.Radius);
                ball.Velocity.Y = Math.Abs(ball.Velocity.Y);
            }
            else if (ball.Position.Y + (ball.Texture.Height / 2 + ball.Radius) >= viewport.Height)
            {
                ball.Position.Y = viewport.Height - (ball.Texture.Width / 2 + ball.Radius);
                ball.Velocity.Y = Math.Abs(ball.Velocity.Y) * -1;
            }
        }

        public static bool BallCollision(Ball bigBall, Ball smallBall)
        {
            float diffX = smallBall.Center.X - bigBall.Center.X;
            float diffY = smallBall.Center.Y - bigBall.Center.Y;
            double distance = Math.Sqrt((diffX * diffX) + (diffY * diffY));

            return smallBall.Radius + distance >= bigBall.Radius;
        }

        public static void WallCollisionHorizontalLeft(Ball ball, GameObject wall)
        {
            if (ball.Position.X + (ball.Texture.Width / 2 + ball.Radius) >= wall.Position.X)
            {
                ball.Position.X = Math.Max(wall.Position.X - (ball.Texture.Width / 2 + ball.Radius), ball.Position.X);
                ball.Velocity.X = Math.Abs(ball.Velocity.X) * -1;
            }
        }
        public static void WallCollisionHorizontalRight(Ball ball, GameObject wall)
        {
            if (ball.Position.X + (ball.Texture.Width / 2 - ball.Radius) <= wall.Position.X + wall.Texture.Width)
            {
                ball.Position.X = Math.Max(wall.Position.X - (ball.Texture.Width / 2 - ball.Radius), ball.Position.X);
                ball.Velocity.X = Math.Abs(ball.Velocity.X);
            }
        }
    }
}
