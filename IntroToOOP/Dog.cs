using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //Create a Dog class
        //Your dog class should have fields for hair length, height, running speed, and weight
        //Your class should have the following behaviors: run, bark, potty, cuddle

        private string hairLength;
        private int height;
        private int runningSpeed;
        private double weight;
        private bool crap = true;
        //Properties
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public double BarkVolume {get;set;} //<-- Creates private field behind the scenes 

        public Dog()
        {
            //This is my default constructor.
        }
        public Dog(string hairLength, int height, int runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }
        public int Run()
        {
            Console.WriteLine("Dog runs");
            RunningSpeed -= 1;
            return RunningSpeed;
        }
        public void Bark()
        {
            Console.WriteLine("Dog barks"); 
        }
        public double Potty()
        {
            if(crap == true)
            {
                Console.WriteLine("Potty time");
            }
            else
            {
                Console.WriteLine("Take the dog out");
                weight += 1.0;
            }
            return weight;
        }
        public void Cuddle()
        {
            Console.WriteLine("Good boy");
        }

        
    

    }
}
