using System;

namespace doit_study_homework_template
{
    public class HW03 : homework
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public HW03(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
        public void main(){
            var A = 10;
            var B = 4;

            Console.WriteLine("A + B = " + (A+B) + ", A - B = " + (A-B) + ", A * B = " + (A*B) + ", A / B = " +(A/B) + ", A % B = " + (A%B));
         
        }
    }
}