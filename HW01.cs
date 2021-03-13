using System;

namespace doit_study_homework_template
{
    public class HW01 : homework
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public HW01(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
        public void main(){
        Console.WriteLine("Hello World!");
        }
    }
}