/* 
    namespace
    이름 충돌을 방지하기 위한 힌트

    동일한 클래스 이름을 구분짓기 위함 
 */


namespace Milkyway
{
    class Earth
    {
        

    }
}

namespace Andromeda
{
    class Earth{}

}

/* 
    호출 방법 Milkyway.Earth Andromeda.Earth

    동일 namespace안에서 namespace. 를 생략하면 동일 스페이스의 클래스를 호출

    보통 클래스를 구분하는데 사용

    using을 사용해서 namespace를 지정해야하는 번거로움을 생략 가능
 */
