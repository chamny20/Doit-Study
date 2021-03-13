using System;

namespace doit_study_homework_template
{
    public class HW02 : homework
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public HW02(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
        public void main(){
            var name = "Bob";
            var messages = 3;
            var temperature = 34.4f;

            Console.WriteLine("Hello, " +name+ "! You have " + messages + " in you inbox. The temperature is " + temperature + " celsius.");
          
        }
    }
}