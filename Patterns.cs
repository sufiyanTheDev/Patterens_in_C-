namespace practice
{
    public class Patterns
    {
        public static void DisplayAllStars(int n){
            for(int i = 0; i < n;i++){
                for(int j = 0;j < n;j++){
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        public static void DisplayTriangleStars(int n){
            for (int i = 0; i<n; i++){
                for (int j = 0; j<=i; j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayAllRowNumberTriangle(int n){
            for(int i =1; i<=n;i++){
                for(int j=0; j<i; j++){
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public static void DisplaySequenceNumberTriangle(int n){
            for(int i=1; i<=n;i++){
                for(int j=1; j<=i; j++){
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayReverseSequenceNumberTriangle(int n){
            for(int i=n; i>=1;i--){
                for(int j=1; j<=i; j++){
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayInverseTriangle(int n){
            for(int i = n; i>=1;i--){
                for(int j=1;j<=i;j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void DisplayCorrectTriangle(int n){
            for(int i=1; i<=n; i++){
                for(int j=1;j<=n-i;j++){
                    Console.Write(" ");
                }
                for(int l=1;l<=2*i-1; l++){
                    Console.Write("*");
                }
                for(int k=1;k<=n-i;k++){
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void DisplayCorrectInverseTriangle(int n){
            for(int i=1; i<=n; i++){
                for(int j=1;j<=i-1;j++){
                    Console.Write(" ");
                }
                for(int l=1;l<=2*n-2*i+1; l++){
                    Console.Write("*");
                }
                for(int k=1;k<=i-1;k++){
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
        public static void DisplayHalfTopTriangle(int n){
            DisplayTriangleStars(n);
            DisplayInverseTriangle(n);
        }
        public static void DisplayBinaryTriangle(int n){
            bool num = true;
            for(int i=1;i<=n;i++){
                for(int j=1;j<=i;j++){
                    Console.Write(num ? "1 " : "0 ");
                    num = !num;
                }
                Console.WriteLine("");
            }   
        }
        public static void DisplayVTriangle(int n){
            for(var i=1;i<=n; i++){
                for(int j=1;j<=i;j++){
                    Console.Write(j);
                }
                for(int k=1; k<= 2*n-2*i; k++){
                    Console.Write(" ");
                }
                for(int j=i;j>=1;j--){
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void DisplayNumberedTriangle(int n){
            int num = 1;
            for(int i=1;i<=n;i++){
                for(int j=1;j<=i;j++){
                    Console.Write(num+" ");
                    
                }
                Console.WriteLine();
            }
        }
        public static void DisplayRightAngleTriangleAlphabets(int n){
            for(int i=1;i<=n;i++){
                for(char ch = 'A';ch <= 'A' + i -1;ch++){
                    Console.Write(ch + " ");
                }
                Console.WriteLine();

            } 
        }
        public static void DisplayInverseRightAngleTriangelAlphabets(int n){
            for(int i=1; i<=n;i++){
                for(char ch = 'A'; ch <= 'A' + n - i ; ch++){
                    Console.Write(ch);
                }
                Console.WriteLine("");
            }
        }

        public static void DisplayRowTriangleAlphabets(int n){
            char ch = 'A';
            for(int i=1;i<=n;i++){
                for(int j =1;j<=i; j++){
                    Console.Write(ch);
                }
                ch++;
                Console.WriteLine("");
            }
        }

        public static void DisplayAlphabetTriangle(int n){
            for (int i=1;i<=n;i++){
                char last = 'A';
                for(int j=1;j<=n-i;j++){
                    Console.Write(" ");
                }
                for(char ch = 'A';ch <= 'A' + i -1;ch++){
                    Console.Write(ch);
                    last = ch;
                }
                last--;
                for(char ah = last; ah >= 'A'  ; ah--){
                    Console.Write(ah);
                }
                for(int j=1;j<=n-i;j++){
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayReverseTriangle(int n){
            
            for(int i=0;i<n;i++){
                for(char ch = Convert.ToChar('E'-i); ch <= 'E'; ch++){
                    Console.Write(ch);
                }
                Console.WriteLine("");
            }
        }

        public static void DisplayDiamondTriangle(int n){
            int init = 0;
            for(int i=1; i<=n;i++){
                for(int j=1; j<=n-i+1; j++){
                    Console.Write("*");
                }
                for(int k=0; k<init; k++){
                    Console.Write(" ");
                }
                for(int j=1; j<=n-i+1; j++){
                    Console.Write("*");
                }
                init +=2;
                Console.WriteLine();
            }
            for(int i=1;i<=n;i++){
                init -=2;
                for(int j=1; j<=i; j++){
                    Console.Write("*");
                }
                for(int k=0; k<init; k++){
                    Console.Write(" ");
                }
                for(int j=1; j<=i; j++){
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }

        public static void DisplayHPattern(int n){
            int stars = n*2-2;
            for(int i=1; i<=n;i++){
                for(int j=1;j<=i;j++){
                    Console.Write("*");
                }
                for(int k=1; k<=stars; k++){
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++){
                    Console.Write("*");
                }
                stars -= 2;
                Console.WriteLine();
            }
            stars = 1;
            for(int i=0;i<=n;i++){ 
                for (int j=0; j<=n-i-2; j++){
                    Console.Write("*");
                }
                for(int k=0;k<=stars;k++){
                    Console.Write(" ");
                }
                for (int j=0; j<=n-i-2; j++){
                    Console.Write("*");
                }
                stars += 2;
                Console.WriteLine();
            }
        }

        public static void DisplayBoxPattern(int n){
            for(int i=1; i<=n; i++){
                if(i==1 || i == n){
                    for(int j = 0; j<n; j++){
                        Console.Write("*");
                    }
                }else{
                    Console.Write("*");
                    for(int j=1; j<=n-2; j++){
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void DiplayInnerNumberSquarePattern(int n){
            for(int i=0; i<= 2*n-1; i++){
                for(int j=0; j<=2*n-1; j++){
                    int top = i;
                    int left = j;
                    int right = (2*n - 2) - i;
                    int down = (2*n - 2) - j;
                    Console.Write( n - Math.Min(Math.Min(top, left), Math.Min(right, down)));
                   
                }
                Console.WriteLine();
            }
        }
    }

}