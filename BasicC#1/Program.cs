/* 
    C#의 자료형

    1. 정수형
        sbyte      -128 ~ 127                                           부호 있는 8비트 정수
        byte        0   ~ 255                                           부호 없는 8비트 정수
        short       -32,768 ~ 32,767                                    부호 있는 16비트 정수
        ushort      0   ~ 65,535                                        부호 없는 16비트 정수
        int         -2,147,483,648 ~ 2,147,483,647                      부호 있는 32비트 정수
        uint        0   ~ 4,294,967,295                                 부호 없는 32비트 정수
        long        -9,223,372,036,854,775,808 ~ 9,223,036,854,775,807  부호 있는 64비트 정수
        ulong       0   ~ 18,446,744,073,709,551,615                    부호 없는 64비트 정수

    자료형 변수명;

    예) int n;   32비트 정수형
        long num;  64비트 정수형


 */

            int n1 = 50; // 선언과 동시에 값을 부여 가능
            int n2; // 선언만 하고
            n2 = 100; // 값은 나중에 부여 가능

            long sum = n1 + n2;


            Console.WriteLine(sum);

/* 
    2. 실수형
        C#              대응되는 닷넷 형식              근사 범위               크기
        =======================================================================================
        float           System.Single                ±1.5e-45 ~ ±3.4e38      4바이트
        double          System.Double                ±5.0e-324 ~ ±1.7e308    8바이트
        decimal         System.Decimal         ±1.0 × 10^-28  ± 7.9 × 10^28  16바이트         
 
    값을 표기할때 특별한 접미사를 사용
    float => f
    decimal => m
 */

 float f = 5.2f;
 double d = 10.5;
 decimal money = 200.099m;

 Console.WriteLine(f);
 Console.WriteLine(d);
 Console.WriteLine(money);


 /* 
    3. 문자형
        C#              대응되는 닷넷 형식              근사 범위               크기
        =======================================================================================      
        char            System.Char                     U+0000 ~ U+FFFF        유니코드 16비트 문자
        string          System.String                   문자열                  유니코드 문자열
          
  */

char ch1 = '\t'; //TAB 문자를 표현
char ch2 = 'T';
char ch3 = '\n'; //개행(NEW LINE)문자를 표현
char ch4 = 'o';

Console.Write(ch1);

Console.Write(ch2);

Console.Write(ch3);

Console.Write(ch4);

// 역슬래시와 함께 u 문자를 사용해 유니코드 문자의 번호를 16진수로 명시

char ch = '\u2026';
Console.Write(ch);

string text = "\tHello\nWorld";
Console.WriteLine(text);

// @문자를 문자열 앞에 붙이면 \를 이스케이프 시퀀스로 간주하지 않고 순수 문자로 취급

string text1 = @"\tHello\nWorld";
Console.WriteLine(text1);

/* 
    4. 불린(boolean)형
        C#              대응되는 닷넷 형식             범위   
     ========================================================================= 
        bool            System.Boolean             true,false    
 

    암시적 형변환

    작은 데이터 타입 => 큰 타입으로 변환 O
    큰 데이터 타입 => 작은 데이터 타입 X

    명시적 형변환

    다른 형태의 데이터 타입으로 변환
*/

ushort u = 65;
char c = (char)u;
Console.WriteLine(c);

int [] arr = new int[]{1,2,3,4,5};

foreach (int elem in arr)
{
    Console.WriteLine(elem);
}


/* 
    점프문

    break,continue,goto,return,throw

    goto => 사용하면 for/foreach/while/do 를 모두 대체 가능 But, 가독성이 현저히 떨어짐
 */

 int sum1 = 0;
 int n = 0;

LOOP:
    n++;
    if (n> 1000)
    {
    goto LOOPEXIT;
    }

    if ((n%2) != 0) goto LOOP;

    sum1 += n;
    goto LOOP;

LOOPEXIT:
    Console.WriteLine(sum1);