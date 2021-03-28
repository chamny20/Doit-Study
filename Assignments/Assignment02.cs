using System;
using System.Collections.Generic;
using DoitStudy.Interface;
using DoitStudy.Testcase;

namespace DoitStudy.Assignments
{
    public class Assignment02 : IAssignment
    {
        public object main(object data){
            string[] strArr = ((TestCase02.TestCase)data).strArr; // Ex:) strArr = {"123", "-123", "32"} 
            int res = 0; // Ex:) res = -91 위의 예제 기준 
            int[] numArr = new int[strArr.Length];
            for(int i=0; i<strArr.Length; i++) {
                int j;
                string s = strArr[i];
                if(int.TryParse(s, out j)) {
                    numArr[i] = j;
                }
            }
          



            return res;
        }
    }
}