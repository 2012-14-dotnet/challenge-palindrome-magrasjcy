use System;

namespace rev.challenge {
     public class riddleReader {
         string riddleIn=Console.ReadLine() ;
         uint result=0,lineno=0;	 
         for (uint index=0;index < riddleIn.length;index ++) { 
             if (riddleIn[index]==riddleIn[riddleIn.length-index])
	     {   lineno++;continue; }
             else { 
		 result=1;
		 Console.WriteLine("line"+lineno+"not a palindrome");
	     }	     
	 }
     }
}
