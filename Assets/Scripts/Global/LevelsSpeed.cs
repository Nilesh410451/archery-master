using UnityEngine;
using System.Collections;

public class LevelsSpeed : MonoBehaviour {	
	
// Specify the targets speed for each level
	
	public static int[,,] _targetsSpeed = {
		{// Level 1
		 // {1st row (left), 2nd row (right), 3rd row (left), 4th row (right)}
			{ 0, 0, 0, 0 }, 			// 0 sec
			{ 500, 0, 0, 0 },             // 1 sec
			{ 0, 0, 0, 0 }, 
			{ 0, 500, 0, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 500, 0 },
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 0, 500 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 500, 0, 500, 0 },	            // 10 sec
			{ 0, 500, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 500, 0, 500 },				
			{ 0, 0, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },				
			{ 500, 500, 500, 500 },
			{ 0, 500, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 500, 0 },             // 20 sec
			{ 500, 500, 500, 500 },
			{ 0, 0, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 0, 0, 500, 500 },
			{ 0, 0, 0, 0 },
			{ 0, 500, 0, 500 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 500 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },	            // 30 sec
			{ 500, 0, 500, 0 },
			{ 0, 500, 0, 500 },
			{ 500, 500, 500, 500 },
			{ 500, 0, 0, 500 },
			{ 0, 500, 500, 0 },
			{ 500, 0, 0, 500 },
			{ 0, 0, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },             
			{ 0, 0, 0, 0 },              // 40 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 50 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 60 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 70 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 80 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 90 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 }              // 100 sec
		},
		
		{// Level 2
			{ 0, 0, 0, 0 }, 			// 0 sec
			{ 600, 0, 0, 0 },             // 1 sec
			{ 0, 0, 800, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 600, 0, 0 }, 
			{ 0, 0, 0, 600 },
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 600, 0, 0, 600 }, 
			{ 0, 600, 600, 0 }, 
			{ 600, 600, 600, 600 },	            // 10 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 600, 600, 600, 600 },				
			{ 600, 0, 600, 0 },
			{ 0, 600, 0, 700 },
			{ 0, 600, 700, 0 },				
			{ 0, 0, 0, 0 },
			{ 0, 600, 600, 0 },
			{ 0, 0, 0, 600 },
			{ 600, 0, 0, 600 },             // 20 sec
			{ 0, 0, 800, 0 },
			{ 0, 0, 0, 600 },
			{ 0, 600, 0, 0 },
			{ 0, 0, 600, 0 },
			{ 800, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 600, 0, 0, 0 },
			{ 0, 0, 600, 0 },
			{ 0, 600, 0, 0 },	            // 30 sec
			{ 600, 0, 0, 0 },
			{ 600, 0, 0, 600 },
			{ 0, 0, 600, 0 },
			{ 0, 600, 0, 0 },
			{ 0, 600, 0, 600 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 600, 600, 0, 0 },
			{ 600, 600, 0, 0 },
			{ 0, 0, 0, 600 },             // 40 sec
			{ 0, 0, 800, 0 },
			{ 600, 0, 0, 600 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 600 },
			{ 0, 0, 0, 0 },
			{ 600, 0, 600, 0 },
			{ 0, 800, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 50 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 60 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 70 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 80 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 90 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 }              // 100 sec
		},
		
		{// Level 3
			{ 0, 0, 0, 0 }, 			// 0 sec
			{ 0, 0, 0, 0 },             // 1 sec
			{ 0, 0, 500, 500 }, 
			{ 500, 500, 0, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 500, 0 },
			{ 0, 500, 0, 500 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 300, 0 }, 
			{ 0, 500, 0, 500 },	            // 10 sec
			{ 0, 500, 0, 500 },
			{ 0, 500, 0, 0 },
			{ 0, 0, 0, 0 },				
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 0, 700, 0 },				
			{ 0, 500, 0, 0 },
			{ 0, 0, 0, 800 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },             // 20 sec
			{ 0, 300, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 500, 0, 600, 0 },
			{ 0, 0, 600, 0 },
			{ 600, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 500, 0 },	            // 30 sec
			{ 0, 0, 500, 0 },
			{ 0, 0, 500, 500 },
			{ 0, 600, 500, 500 },
			{ 0, 600, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 500, 0 },
			{ 500, 0, 500, 0 },
			{ 500, 0, 500, 0 },
			{ 0, 400, 0, 0 },             // 40 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 500, 0 },
			{ 0, 500, 0, 0 },
			{ 0, 500, 0, 500 },
			{ 500, 0, 0, 0 },
			{ 0, 0, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },             // 50 sec
			{ 0, 500, 0, 0 },
			{ 500, 500, 500, 0 },
			{ 0, 500, 500, 0 },
			{ 0, 0, 0, 800 },
			{ 0, 0, 0, 800 },
			{ 0, 500, 0, 800 },
			{ 700, 500, 700, 0 },
			{ 700, 0, 700, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 60 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 70 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 80 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 90 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 }              // 100 sec
		},
		
		{// Level 4
		 // {1st row (left), 2nd row (right), 3rd row (left), 4th row (right)}
			{ 0, 0, 0, 0 }, 			// 0 sec
			{ 0, 0, 0, 0 },             // 1 sec
			{ 0, 400, 0, 0 }, 
			{ 0, 400, 0, 0 }, 
			{ 0, 400, 400, 0 }, 
			{ 0, 0, 400, 0 },
			{ 0, 0, 400, 800 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 400, 0, 0 },	            // 10 sec
			{ 0, 400, 0, 0 },
			{ 0, 400, 500, 600 },
			{ 0, 0, 0, 600 },				
			{ 0, 0, 0, 600 },
			{ 0, 500, 0, 0 },
			{ 0, 500, 0, 0 },				
			{ 500, 500, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 0, 0, 0 },             // 20 sec
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 500, 0, 500, 0 },
			{ 0, 500, 0, 500 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 500, 0, 500, 0 },	            // 30 sec
			{ 0, 500, 0, 500 },
			{ 500, 0, 600, 0 },
			{ 0, 500, 0, 500 },
			{ 500, 0, 600, 0 },
			{ 0, 500, 0, 500 },
			{ 0, 0, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },             
			{ 400, 0, 0, 0 },              // 40 sec
			{ 400, 500, 0, 0 },
			{ 400, 500, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 800, 800 },
			{ 0, 0, 800, 800 },
			{ 0, 0, 800, 800 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 50 sec
			{ 0, 0, 0, 0 },
			{ 0, 400, 0, 0 },
			{ 0, 400, 0, 0 },
			{ 0, 400, 0, 600 },
			{ 0, 0, 0, 600 },
			{ 0, 0, 0, 600 },
			{ 0, 0, 300, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 400, 0 },              // 60 sec
			{ 0, 500, 400, 0 },
			{ 0, 0, 400, 0 },
			{ 600, 0, 0, 0 },
			{ 600, 0, 0, 0 },
			{ 600, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 700, 0, 0 },              // 70 sec
			{ 500, 0, 0, 500 },
			{ 0, 0, 500, 0 },
			{ 500, 0, 0, 500 },
			{ 0, 0, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 80 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 90 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 }              // 100 sec
		},
		
		{// Level 5
		 // {1st row (left), 2nd row (right), 3rd row (left), 4th row (right)}
			{ 0, 0, 0, 0 }, 			// 0 sec
			{ 0, 0, 0, 0 },             // 1 sec
			{ 400, 0, 0, 0 }, 
			{ 0, 500, 0, 0 }, 
			{ 0, 0, 500, 0 }, 
			{ 0, 0, 0, 500 },
			{ 0, 0, 0, 0 }, 
			{ 0, 500, 0, 500 }, 
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 500, 0 }, 
			{ 500, 0, 500, 0 },	            // 10 sec
			{ 0, 0, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },				
			{ 400, 0, 0, 0 },
			{ 0, 400, 0, 0 },
			{ 0, 400, 500, 500 },				
			{ 0, 400, 500, 0 },
			{ 0, 0, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 500, 500, 400 },             // 20 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 300, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 800, 0, 300, 0 },
			{ 600, 0, 0, 700 },
			{ 600, 0, 0, 700 },
			{ 0, 0, 0, 700 },
			{ 0, 0, 0, 400 },	            // 30 sec
			{ 0, 0, 0, 0 },
			{ 400, 0, 400, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 400, 0, 400 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 400, 0, 500 },             
			{ 0, 400, 0, 500 },              // 40 sec
			{ 0, 400, 500, 500 },
			{ 0, 400, 0, 500 },
			{ 0, 400, 600, 500 },
			{ 0, 400, 300, 500 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 400, 0, 0, 0 },
			{ 400, 0, 500, 0 },              // 50 sec
			{ 400, 600, 500, 0 },
			{ 0, 0, 500, 500 },
			{ 0, 0, 0, 500 },
			{ 0, 0, 0, 500 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 500, 700, 0 },
			{ 0, 0, 400, 500 },              // 60 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 600, 0, 500, 0 },
			{ 0, 500, 500, 0 },
			{ 0, 500, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 300, 0, 700, 0 },              // 70 sec
			{ 0, 500, 700, 0 },
			{ 0, 0, 700, 0 },
			{ 0, 0, 0, 500 },
			{ 400, 600, 400, 500 },
			{ 0, 600, 400, 500 },
			{ 0, 600, 0, 500 },
			{ 0, 600, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 80 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 90 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 }              // 100 sec
		},
		
		{// Level 6
		 // {1st row (left), 2nd row (right), 3rd row (left), 4th row (right)}
			{ 500, 0, 0, 0 }, 			// 0 sec
			{ 0, 0, 0, 0 },             // 1 sec
			{ 500, 500, 0, 500 }, 
			{ 0, 500, 0, 500 }, 
			{ 500, 500, 0, 500 }, 
			{ 0, 0, 500, 0 },
			{ 500, 0, 0, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 500, 0, 0, 0 }, 
			{ 500, 500, 500, 500 }, 
			{ 500, 0, 0, 0 },	            // 10 sec
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 500, 0, 700 },				
			{ 500, 500, 400, 500 },
			{ 0, 500, 0, 500 },
			{ 500, 500, 0, 0 },				
			{ 0, 0, 400, 500 },
			{ 500, 500, 0, 0 },
			{ 600, 400, 0, 500 },
			{ 500, 0, 0, 0 },             // 20 sec
			{ 0, 0, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 500, 500, 450, 0 },
			{ 0, 500, 450, 700 },
			{ 0, 500, 450, 700 },
			{ 500, 0, 0, 700 },	            // 30 sec
			{ 500, 500, 500, 0 },
			{ 0, 0, 500, 0 },
			{ 500, 500, 0, 600 },
			{ 0, 0, 300, 600 },
			{ 0, 500, 0, 600 },
			{ 500, 500, 0, 500 },
			{ 500, 500, 0, 500 },
			{ 0, 0, 400, 500 },
			{ 0, 0, 0, 0 },             
			{ 500, 0, 0, 0 },              // 40 sec
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 500, 500, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 500, 500, 0, 600 },
			{ 500, 500, 500, 600 },
			{ 500, 0, 0, 600 },
			{ 0, 0, 500, 600 },
			{ 500, 0, 0, 0 },
			{ 0, 0, 600, 0 },              // 50 sec
			{ 500, 500, 0, 500 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 500, 0, 600, 0 },
			{ 500, 800, 600, 0 },
			{ 0, 0, 600, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 400, 0, 0 },              // 60 sec
			{ 0, 0, 500, 0 },
			{ 700, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 800, 0, 0, 0 },
			{ 500, 0, 500, 0 },
			{ 400, 500, 0, 0 },
			{ 0, 500, 0, 0 },              // 70 sec
			{ 0, 500, 300, 0 },
			{ 0, 500, 0, 700 },
			{ 0, 500, 0, 700 },
			{ 0, 500, 0, 700 },
			{ 0, 0, 0, 700 },
			{ 500, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 500, 0, 0 },
			{ 500, 500, 500, 0 },
			{ 500, 500, 0, 0 },              // 80 sec
			{ 0, 500, 300, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 600, 0, 600 },
			{ 500, 600, 0, 600 },
			{ 0, 600, 0, 600 },
			{ 500, 600, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 6, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 90 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 }              // 100 sec
		},
		
		{// Level 7
		 // {1st row (left), 2nd row (right), 3rd row (left), 4th row (right)}
			{ 0, 0, 0, 0 }, 			// 0 sec
			{ 0, 0, 0, 0 },             // 1 sec
			{ 400, 500, 0, 0 }, 
			{ 400, 500, 0, 0 }, 
			{ 400, 500, 0, 0 }, 
			{ 0, 0, 0, 0 },
			{ 0, 500, 700, 0 }, 
			{ 0, 500, 700, 0 }, 
			{ 500, 0, 700, 0 }, 
			{ 0, 0, 0, 500 }, 
			{ 0, 0, 0, 0 },	            // 10 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 400, 0 },
			{ 300, 0, 400, 0 },				
			{ 300, 700, 400, 0 },
			{ 300, 700, 400, 0 },
			{ 0, 500, 0, 0 },				
			{ 0, 0, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 0, 500, 0, 0 },
			{ 0, 500, 0, 0 },             // 20 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 600, 0, 0 },
			{ 0, 500, 400, 500 },
			{ 0, 500, 400, 500 },
			{ 0, 500, 0, 500 },
			{ 0, 0, 0, 400 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },	            // 30 sec
			{ 0, 0, 0, 400 },
			{ 0, 500, 500, 0 },
			{ 500, 500, 0, 0 },
			{ 500, 0, 300, 0 },
			{ 500, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },             
			{ 600, 300, 0, 300 },              // 40 sec
			{ 600, 300, 600, 300 },
			{ 0, 300, 600, 300 },
			{ 600, 0, 600, 0 },
			{ 600, 0, 0, 0 },
			{ 600, 0, 400, 0 },
			{ 0, 0, 400, 0 },
			{ 600, 0, 400, 0 },
			{ 0, 0, 0, 0 },
			{ 600, 0, 0, 0 },
			{ 600, 0, 0, 0 },              // 50 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 500, 0 },
			{ 0, 500, 0, 700 },
			{ 0, 0, 0, 700 },
			{ 0, 0, 0, 700 },
			{ 0, 0, 0, 0 },
			{ 400, 300, 0, 0 },
			{ 400, 0, 500, 0 },              // 60 sec
			{ 400, 0, 500, 800 },
			{ 0, 0, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 600, 0, 0 },
			{ 500, 0, 400, 500 },
			{ 500, 500, 400, 500 },
			{ 500, 500, 400, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 70 sec
			{ 500, 0, 0, 0 },
			{ 500, 500, 650, 0 },
			{ 500, 0, 650, 0 },
			{ 500, 500, 500, 0 },
			{ 500, 500, 500, 500 },
			{ 500, 0, 500, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 0, 500, 400, 600 },              // 80 sec
			{ 400, 500, 400, 500 },
			{ 400, 500, 400, 500 },
			{ 0, 500, 0, 500 },
			{ 0, 0, 0, 500 },
			{ 500, 0, 0, 0 },
			{ 500, 500, 0, 500 },
			{ 500, 500, 500, 500 },
			{ 0, 0, 0, 500 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 90 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 }              // 100 sec
		},
		
		{// Level 8
		 // {1st row (left), 2nd row (right), 3rd row (left), 4th row (right)}
			{ 0, 0, 0, 0 }, 			// 0 sec
			{ 0, 0, 0, 0 },             // 1 sec
			{ 400, 0, 0, 0 }, 
			{ 400, 0, 500, 0 }, 
			{ 400, 600, 500, 0 }, 
			{ 0, 400, 500, 0 },
			{ 0, 0, 0, 0 }, 
			{ 0, 0, 0, 0 }, 
			{ 500, 0, 600, 0 }, 
			{ 0, 500, 500, 700 }, 
			{ 0, 0, 0, 300 },	            // 10 sec
			{ 0, 0, 500, 0 },
			{ 0, 0, 500, 0 },
			{ 0, 0, 500, 0 },				
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },				
			{ 500, 400, 500, 0 },
			{ 0, 400, 0, 0 },
			{ 0, 400, 0, 600 },
			{ 0, 400, 0, 600 },             // 20 sec
			{ 0, 0, 0, 600 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 500 },
			{ 500, 0, 0, 0 },          //test
			{ 500, 0, 600, 0 },
			{ 500, 600, 600, 0 },
			{ 500, 600, 600, 0 },
			{ 0, 600, 600, 0 },
			{ 0, 0, 0, 0 },
			{ 600, 0, 0, 0 },	            // 30 sec
			{ 0, 0, 0, 0 },
			{ 600, 300, 600, 300 },
			{ 400, 300, 0, 300 },
			{ 400, 300, 0, 300 },
			{ 0, 0, 0, 0 },
			{ 450, 0, 0, 0 },
			{ 0, 500, 0, 500 },
			{ 500, 500, 500, 0 },
			{ 0, 0, 500, 0 },             
			{ 500, 0, 0, 0 },              // 40 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 600, 0, 0, 0 },
			{ 0, 0, 0, 500 },
			{ 600, 500, 600, 500 },
			{ 600, 500, 600, 0 },
			{ 600, 500, 600, 500 },
			{ 0, 500, 500, 0 },
			{ 500, 0, 500, 500 },
			{ 0, 0, 0, 0 },              // 50 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 400, 0, 0 },
			{ 500, 400, 0, 0 },              //test
			{ 0, 0, 0, 350 },
			{ 600, 0, 600, 0 },
			{ 600, 600, 600, 400 },
			{ 600, 600, 600, 400 },
			{ 0, 600, 0, 400 },              // 60 sec
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 400, 0, 0 },
			{ 500, 400, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 500, 400, 500, 400 },
			{ 500, 400, 500, 400 },
			{ 500, 400, 500, 400 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },              // 70 sec
			{ 0, 0, 0, 0 },
			{ 400, 500, 0, 0 }, 
			{ 400, 500, 0, 0 }, 
			{ 400, 500, 0, 0 }, 
			{ 0, 0, 0, 0 },
			{ 0, 500, 700, 0 }, 
			{ 0, 500, 700, 0 }, 
			{ 500, 0, 700, 0 }, 
			{ 0, 0, 0, 500 }, 
			{ 0, 0, 0, 0 },              // 80 sec
			{ 0, 0, 0, 0 },
			{ 500, 0, 0, 0 },
			{ 500, 700, 0, 500 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 400, 0, 0, 0 },
			{ 400, 0, 0, 0 },
			{ 400, 0, 600, 500 },
			{ 0, 0, 600, 500 },
			{ 0, 400, 600, 500 },              // 90 sec
			{ 0, 400, 600, 500 },
			{ 0, 400, 0, 0 },
			{ 0, 400, 0, 500 },
			{ 500, 0, 700, 500 },
			{ 500, 500, 0, 500 },
			{ 500, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 }              // 100 sec
		}
	};
}
	
