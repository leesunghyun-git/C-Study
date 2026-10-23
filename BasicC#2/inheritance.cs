/* 
    상속(inheritance)

    공통된 메서드와 상태값을 부모 클래스 (parent class)를 두고 자식 클래스 (Child class)가 물려받음
    
 */

 public class Computer
{
    protected bool powerOn;
    public void Boot() {}
    public void Shutdown(){}
    public void Reset(){}

}

public class NoteBook : Computer
{
    bool fingerScan; // Notebook 타입에 해당하는 멤버만 추가
    public bool HasFingerScanDevice() {return fingerScan;}

    public void CloseLid()
    {
        //Shutdown(); // 부모 클래스의 메소드 호출 가능
        if (powerOn == true) // 부모 클래스의 멤버의 접근제한자가 설정안됨 => private => 자식 클래스에서 사용 불가
        // protected로 변경시 사용 가능
        {
            
        }
    
    }
}

public class Desktop : Computer
{
    
}

public class Netbook : Computer
{
    
}

// : 를 사용해서 상속 가능
// 의도적으로 상속을 막는법 sealed => 상속 불가 class
// ex) sealed class Pen

// C#에서는 단일 상속만 가능, 2개이상의 부모 클래스를 하나의 자식클래스가 상속 X
/* 
    자식클래스가 부모클래스로 암시적 형변환 가능
    ex)
    Notebook notebook = new Notebook();

    Computer pc1 = notebook; <== 가능
    pc1.boot();
    pc2.Shutdonw();

    but) 부모 클래스가 자식클래스로 형변환 불가능

    Computer pc = new Computer();
    Notebook notebook = (Notebook)pc; <== 명시적 형변환, 컴파일은 가능
    But) 실행하면 오류 발생

 */

 // as , is 연산자

 /* 
    캐스팅 연산자를 이용한 명시적 형변환 => 오류발생
    오류를 발생시키지 않고 형변환이 가능한지 확인 가능한 연산자 = as

    Computer pc = new Computer();
    Notebook notebook = pc as Notebook;

    if (notebook != null)
    {
        notebook.CloseLid();
    }

    as => 형변환이 가능하면 지정한 타입의 인스턴스 값을 반환하고, 불가능 하면 null을 반환
        null 반환 여부로 형변환이 성공했는지 판단 가능
        단, 참조형 변수에 대해서만 적용 가능, 참조형 타입으로의 체크만 가능

    잘못된 예시
    ex) 
    int n = 5;
    if ((n as string) !=null) // 컴파일 오류 발생
    {
        Console.WriteLine("변수 n은 string 타입");
    }

    string txt = "text";

    if ((txt as int) != null) // 컴파일 오류 발생
    {
        Console.WriteLine("변수 txt는 int 타입");
    }


    is 연산자 
    형변환 가능성의 여부를 boolean형으로 반환 (true/false)
    또한 is 연산자는 값 형식에도 사용 가능
  */