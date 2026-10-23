/* 
    접근자/설정자 메서드를 일일이 코드로 작성하는 것이 번거로움
    => property 문법을 사용
 */

 /* 
    class 클래스_명
    {
        접근_제한자 타입 프로퍼티_명
        {
            접근_제한자 get
            {
                //...[코드]...
                return 프로퍼티의 타입과 일치하는 유형의 표현삭;
            }
            접근_제한자 set
            {
                //...[코드]...
            }
        }
    }

    =>
    class 클래스_명
    {
        타입 멤버명;

        public 타입 프로퍼티_명
        {
            get { return ...};
            set { 멤버명 = value};
        }
    }
  */

  class Circle
{
    double pi = 3.14;

    public double Pi
    {
        get {return pi;}
        set {pi = value;} // value는 property가 set 블록 내부에서만 사용하는 예약어
    }

    // ...[생략]...
}

// => 컴파일러가 자동으로 메소드로 변형

