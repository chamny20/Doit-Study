using System.Linq;
using System;
using System.Collections.Generic;
using DoitStudy.Interface;
using DoitStudy.Utils;
using DoitStudy.Assignments;
using DoitStudy.Testcase;

namespace DoitStudy
{
    class Program
    {
        static void Main(string[] args)
        {

            IAssignmentRunning[] assignments = {
                new AssignmentRunning(new Assignment01(), new TestCase01()), 
                new AssignmentRunning(new Assignment02(), new TestCase02()),
            };

            assignments[0].isRunning = true; //1번 Assignment  // 결과를 보고싶은 과제의 false를 true로 수정하세요
            assignments[1].isRunning = true; //2번 Assignment // 반대로 결과를 가리고 싶은 과제를 true에서 false로 수정하세요

            foreach(var temp in assignments){
                if(temp.isRunning)
                    temp.RunCode();
            }
        }

    }
}
