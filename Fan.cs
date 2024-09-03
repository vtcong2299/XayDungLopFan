using System;
using System.Runtime.Serialization;


namespace  XayDungLopFan
{
    public class  Fan
    {
        public const int slow =1;
        public const int medium =2;
        public const int fast =3;
        private int speed = slow;
        private bool on = false;
        private double radius = 5;
        private string color = "Blue";
        public int getSpeed()
        {
            return speed;
        }
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }
        public bool getOn()
        {
            return on;
        }
        public void setOn(bool on)
        {
            this.on = on;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public Fan() { }
        public Fan(int speed, bool on, double radius, string color)
        {
            this.speed = speed;
            this.on = on;
            this. radius = radius;
            this. color = color;
        }
        
        public new string ToString()
        {
            string info="";
            if (on)
            {
                info = "Fan is on, speed = "+speed+", ban kinh = "+ radius+", mau sac = "+color;
            }
            else

            {
                info = "Fan is off, ban kinh = "+ radius+", mau sac = "+color;
            }
            return info;
        }
    }
}