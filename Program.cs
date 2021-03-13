using System;

namespace doit_study_homework_template
{
    public interface homework{
        bool isRunning { get; set;}
        void main();
    }

    class Program
    {
        static void Main(string[] args)
        {
            homework[] hw = {
                new HW01(true), // 결과를 보고싶은 과제의 false를 true로 수정하세요
                new HW02(true), // 반대로 결과를 가리고 싶은 과제를 true에서 false로 수정하세요
                new HW03(true) // before => "HW03(false)" // after => "HW03(true)"
            };

            foreach(var temp in hw){
                if(temp.isRunning)
                    temp.main();
            }
        }

    }
}
