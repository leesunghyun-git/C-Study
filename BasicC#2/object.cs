// Object 
/* 
    C#의 최상위 클래스
    모든 클래스는 object를 상속받은 자식클래스
 */

 /* 
    Object의 메소드

    public class Object
    {
        public virtual bool Eqauls(object obj);
        public virtual int GetHashCode();
        public Type GetType();
        public virtual string ToString();
    }
  */

/* 
    1. ToString 
    해당 인스턴스가 속한 클래스의 전체 이름 호출(FQDN)

    but 기본 타입들 (string,int,short,...)은 클래스의 전체 이름이 아닌 해당 타입이 담고 있는 값을 반환

    2. GetType
    타입의 정보를 담고있는 System.Type의 인스턴스를 가져오는 메서드

    Computer computer = new Computer();
    Type type computer.getType();

    Console.WriteLine(type.FullName); // Type 클래스의 FullName 프로퍼티 호출
    Console.WriteLine(type.IsClass); // Type 클래스의 IsClass 프로퍼티 호출
    Console.WriteLine(type.IsArray); // Type 클래스의 IsArray 프로퍼티 호출
    
    
    3. Equals
    값을 비교한 결과를 불린형으로 반환

    값 형식은 해당 인스턴스가 소유하고 있는 값을 대상으로 비교
    참조 형식을 비교하는 경우 할당하고 있는 메모리 위치를 비교

    4. GetHashCode
    특정 인스턴스를 고유하게 식별할 수 있는 4바이트 int 값을 반환   

 */ 