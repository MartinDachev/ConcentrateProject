using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace BouncingBallGame
{
    public class Ball
    {
        public Texture2D Texture;
        public Vector2 Position;
        public Vector2 Velocity;
        public Vector2 Center;
        public double Speed;
        public float Radius;
        public float maxVelocity;
        public float minVelocity;

        public Ball()
        {

        }

        public Ball(Texture2D Texture, Vector2 Position, Vector2 Velocity, float Radius)
        {
            this.Texture = Texture;
            this.Position = Position;
            this.Velocity = Velocity;
            this.Radius = Radius;
            this.Center = new Vector2(this.Position.X + this.Texture.Width / 2, this.Position.Y + this.Texture.Height / 2);
        }

        public void NextPosition(double elapsedTime)
        {
            this.Position.X += (float)(this.Velocity.X * elapsedTime);
            this.Position.Y += (float)(this.Velocity.Y * elapsedTime);
            this.UpdateCenter();
        }

        public void UpdateCenter()
        {
            this.Center.X = this.Position.X + this.Texture.Width / 2;
            this.Center.Y = this.Position.Y + this.Texture.Height / 2;
        }

        public void RandomVelocity(Random r)
        {
            this.Velocity.X = (float)(r.NextDouble() * (this.maxVelocity - this.minVelocity) + this.minVelocity);
            this.Velocity.Y = (float)(r.NextDouble() * (this.maxVelocity - this.minVelocity) + this.minVelocity);
            int xd = r.Next(0, 2);
            int yd = r.Next(0, 2);
            if(xd == 0) xd = -1;
            if(yd == 0) yd = -1;
            this.Velocity.X *= xd;
            this.Velocity.Y *= yd;
            this.Speed = Math.Sqrt((this.Velocity.X * this.Velocity.X) + (this.Velocity.Y * this.Velocity.Y));
        }

        public void IncreaseVelocityLimits(float increaseValue)
        {
            this.minVelocity += increaseValue;
            this.maxVelocity += increaseValue;
        }
    }
}